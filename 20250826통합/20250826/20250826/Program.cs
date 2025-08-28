#define Test

using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _20250826
{
    // Reflection = 클래스용 X - ray 촬영
    // 자주 사용하지 않음 - 그냥 개념을 알고 있으면 됨

    // Atribute


    // 이 클래스는 몬스터 클래스이다!

    class Impotrant : Attribute
    {
        public string message;

        public Impotrant(string message)
        {
            this.message = message;
        }

        
    }
    [Impotrant("이건 중요한 메세지야, 니가 런타임에 확인해")]
    class Monster
    {
        public int hp;
        protected int atk;
        private float speed;

        //빌드는 되지만 사용하지 말라고 뜸
        [Obsolete]
        public static void Test1()
        {
            Console.WriteLine("Test가 호출됨");
        }

        // 빌드는 되지만 사용하지 말라고 뜸, 그리고 추가 메세지 넣음
        [Obsolete("이거 더이상 사용 안되니까 하지마셈")]
        public static void Test2()
        {
            Test3();
        }

        // 더 이상 빌드도 안되게 막아버림
        [Obsolete("하지마삼", true)]
        
        static void Test3()
        {
            Console.WriteLine("Test가 호출됨");
        }

        // 해당 문서(이 문서) 최상단에 #define 으로 정의 한 내용이 없으면 실행 안되게
        // 즉, if문처럼 맨 위에 #define Test 이거 없으면 이 함수 호출해도 실행 안됨.
        [Conditional("Test")] /* --> Test4의 명령문대로 호출 */
        public static void Test4()
        {
            Test5();
        }

         static void Test5()
        {
            Console.WriteLine("Test가 호출됨");
        }

        // 닷넷 환경 밖에서 개발된 코드를 가져오고 싶을 때
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string title, string message, int buttons);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("실행 중에 몬스터에 있는 필드들을 전부 꺼내서 출력");

            Monster monster = new Monster();

            Type type = monster.GetType();

           var fiedlds = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach (var field in fiedlds)
            {
                string access = "protected";

                if (field.IsPublic == true)
                    access = " public";
                else if (field.IsPrivate == true)
                    access = " private";

                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");

            }
           var attributes = type.GetCustomAttributes();
            foreach (var attribute in attributes)
            {
                Impotrant important = attribute as Impotrant;
                if (important != null)
                {
                    Console.WriteLine(important.message);
                }
            }
            Monster.Test1(); // 오류메세지 --> 'Monster.Test1()'은(는) 사용되지 않습니다.
            Monster.Test2(); // 오류메세지 --> 'Monster.Test2()'은(는) 사용되지 않습니다. '이거 더이상 사용 안되니까 하지마셈'
        //  Monster.Test3(); 아예 사용을 못하게 만듦

            Monster.Test4();
        }
    }
}

namespace _20250822
{
    class MyIntLIst
    {
        int[] arr = new int[10];
    }
    class MyFloatList
    {
        float[] arr = new float[10];
    }

    class MyStringList
    {
        string[] arr = new string[10];
    }

    class MyBoolLIst
    {
        bool[] arr = new bool[10];
    }


    class MyMonsterList
    {
        // 문제점
        //  object[] arr = new object[10];   ---> 속도가 느려진다. 
    }

    //class Monster
    //{
    //    Monster(int a) { } // 매개변수가 있는 생성자
    //}
    class Generic<T>
    {

        /*
         *   배열 = 고정된 크기의 데이터를 순서대로 저장
             리스트 = 배열과 비슷한데 크기가 자유롭게 늘어나고 줄어드는 더 유연한 구조
            딕셔너리 = 키(key)와 값(value) 쌍을 사용해서 데이터를 더 빠르고 쉽게 꺼낼 수 있는 구조

        인벤토리 - 리스트,
        아이템 정보 - 딕셔너리,
        맵의 오브젝트 ID - 배열

        List<int>
        Dictinoary<int, string>

         object = c#에서 모~~~~~든 타입의 조상 클래스 , 모든 애들의 부모.
         object obj = new Moster();
         object obj =3 , " 하하하하 " , false ;

         // var  간편하게 쓸 수 있도록 형식을 일치화 시키는 키워드
         var = 타입을 추론
         var a =3 , " ssss " , false,  4.5 ;
         var a = 3;                      // 컴파일러 : "3은 int이니까 test는 int구나"
         var text = " 하하하하 "         // 컴파일러 : " 이건 문자열이니ㅔ"

         @@ Boxing 박싱
         object test = 3;
         @@ UnBoxing 언박싱
         int b = ( int ) test;

         object a = 3;       --> 박싱 : 스택 ~> 힙
         int number = (int)a;-->언박싱: 힙   ~> 스택

         @@ 절대 하지 마라
        MyObjectList myList = new MyOvjectList();
        MyList.arr[0] = 3;                  // 박싱
        int value = (int)myLIst.arr[0];     // 언박싱

         ----------------------------------------------------
         제네릭이란 타입을 나중에 결정하는 설계도
         Generic(일반화)
        장점
        - 1. 타입별로 중복되는 코드를 만들 필요 없음
        - 2. object 처럼 박싱/ 언박싱이 필요 없으니 성능 향상
        - 3. 잘못된 타입을 넣으려 하면 컴파일 시점에서 에러 잡아줌
         // class Generic<T> ,, class MkList<key, Value>
        T: 관례 예) for( int 'i') Type의 약자, 템플릿의 약자
        T라는 게 결과적으로 런타임에 우리가 지정해준 형식으로 치환됨

            Class MyList<T> Where T : new()
            Class MyList<T> Where T : Class, new() // T는 반드시 참조 형식의 데이터 타입만 가능하다
            Class MyList<t> Where T : struct       // T는 반드시 값 형식의 데이터 타입만 가능하다

            예)
                Class MyList<t> Where T : class ------------> 오류 
                    public void Test()
                {
                    T t = new T();
                }

         Class MyList<t> Where T : class ,new()
            public void Test()
                {
                    T t = new T();
                }
        Generic<Monster> myMonsterList = new Generic<Monster>() --> 오류가 난다. 왜냐하면 Monster 클래스에 매개변수가 있는 상속자이기때문이다.
        
         */
        T[] arr = new T[10];

        public T GetItem(int index)
        {
            return arr[index];
        }


    }
    #region 제네릭 오전
    //class Program
    //{
    //    static public void Test<T>(T value)
    //    {
    //        Console.WriteLine($"입력된 값 :{ value}");
    //    }

    //    static void Main()
    //    {
    //        Generic<int> myIntList = new Generic<int>();                // int 전용 리스트
    //        Generic<string> myStringList = new Generic<string>();       // string 전용 리스트
    //        Generic<Monster> myMonsterList = new Generic<Monster>();    // Moster 전용 리스트

    //        int test3 = myIntList.GetItem(1);

    //        Test(3);                                                    // int 타입으로 호출하면서 추론
    //        Test("Hello");                                              // string 타입으로 호출하면서 추론
    //        Test(3.14f);                                                // float 타입으로 호출 하면서 추론

    //        // -----------------------------언어를 자기혼자만 보느것이 아니기 때문에 짙은 파랑으로 설명이 필요하다

    //        Test<int>(3);                                               // int 타입으로 호출
    //        Test<string>("hello");                                      // string 타입으로 호출
    //        Test<float>(3.14f);                                         // float 타입으로 호출
    // =================================================================
    // 문제
    // 인벤토리 라는 이름의 제네릭 클래스를 만들고, 아래 3개의 함수를 구현하세요.

    //  int Count() → 현재 인벤토리에 들어있는 아이템 개수를 반환
    //  void Add(T item) → 인벤토리에 아이템을 추가
    //  T Get(int index) → 인벤토리에서 해당 위치(index)의 아이템을 가져오기

    //  그리고 Main 함수에서 아래와 같이 사용해 보세요.
    //  Inventory<int>를 만들어 10, 20을 추가한 뒤, 개수와 인덱스 1의 값을 출력
    //  Inventory<string>을 만들어 "Sword", "Potion"을 추가한 뒤, 개수와 인덱스 0의 값을 출력

    // 출력결과
    //  Count:Int = 2
    //  Item: Int[1] = 20
    //  Count: String = 2
    //  Item: String[0] = Sword
    //class Inventory<T>
    //{
    //    List<T> items = new List<T>();
    //    public int Count()
    //    {
    //        return items.Count; //현재 인벤토리에 들어있는 아이템 개수를 반환
    //    }

    //    public void Add(T item)
    //    {
    //        items.Add(item); // 인벤토리에 아이템을 추가
    //    }

    //    public T Get(int index)
    //    {
    //        return items[index];//인벤토리에서 해당 위치(index)의 아이템을 가져오기
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Inventory<int> inventory1 = new Inventory<int>(); //클래스 인벤토리의 리스트를 인스턴스
    //        inventory1.Add(10);
    //        inventory1.Add(20);
    //        Console.WriteLine($"Count: Int = {inventory1.Count()}");
    //        Console.WriteLine($"Item: Int[1] = {inventory1.Get(1)}");

    //        Inventory<string> inventory2 = new Inventory<string>();
    //        inventory2.Add("Sword");
    //        inventory2.Add("Potion");
    //        Console.WriteLine($"Count: String = {inventory2.Count()}");
    //        Console.WriteLine($"Item: String[0] = {inventory2.Get(0)}");
    //    }
    //}
    //    }
    //}
    #endregion

    #region 추상클래스
    //  추상클래스 : 상속 구조에서 특정 기능을 반드시 구현하도록 강제 할 수 있음
    //  하나 이상의 추상함수를 갖고 있는 클래스
    // 일종의 미완성 설계도
    //  추상 클래스는 미완성 클래스 이기에 객체를 생성할 수 없음

    //abstract public class Monster
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("몬스터가 한 칸 이동합니다.");
    //    }
    //    abstract public void Attact();


    //}

    //public class Orc : Monster
    //{
    //    public override void Attact()
    //    {
    //        Console.WriteLine("오크가 몽둥이로 공격!");
    //    }
    //}

    //public class Skeleton : Monster
    //{
    //    public override void Attact()
    //    {
    //        Console.WriteLine("스켈레톤이 화살을 발사!");
    //    }


    //    static void Main()
    //    {
    //        Monster ocr = new Orc();
    //        Monster skeleton = new Skeleton();

    //        ocr.Move();
    //        skeleton.Move();
    //        ocr.Attact();
    //        skeleton.Attact();
    //    }




    //}
    //    abstract class Monster
    //{
    //    public abstract void Attack();
    //    public void Move() => System.Console.WriteLine("Monster Move");
    //}

    //class Orc : Monster
    //{
    //    public override void Attack()
    //    {
    //        System.Console.WriteLine("Orc Attack");
    //    }
    //}

    //class Skeleton : Monster
    //{
    //    public override void Attack()
    //    {
    //        System.Console.WriteLine("Skeleton Attack");
    //    }
    //}

    //class TestCS
    //{
    //    public static void Main(string[] args)
    //    {
    //        Monster[] Monsters = new Monster[2];
    //        Monsters[0] = new Orc();
    //        Monsters[1] = new Skeleton();

    //        Monsters[0].Move();
    //        Monsters[0].Attack();
    //        Monsters[1].Move();
    //        Monsters[1].Attack();
    //    }
    //}
    #endregion

    class Program
    {
        //


        static void Main(string[] args)
        {


        }
    }
}

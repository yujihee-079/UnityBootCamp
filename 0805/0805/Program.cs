using System;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;

// 목차
// 클래스 생성법
// 클래스 객체 생성법
// 객체 호출해서 값 가져오거나 넣는 법
// 참조 형식 N 값 형식
// 얕은 복사 N 깊은 복사

namespace MyApp
{
    // 얕은 복사 (Shallow Copy)
    // 스택의 주소 값만 복사하는 것.

    // 깊은 복사 (Deep Copy)
    // 힙의 내용물을 복사하면 그게 깊은 복사

    /*
      메모리 구조
      
      코드영역(텍스트 영역) 
      데이터 영역
     
     * 힙 영역
      동적할당 하는 애들이 여기 올라감 <- 지금은 몰라도 됩니다.
      클래스로 객체를 생성하면 그 데이터(값)이 힙 영역에 올라갑니다.
      
      [ ][  ]....+n
      계속 생성됩니다..
     * -------------------------------------------------------------
      
     * 스택 영역
      임시적이고 불완전한 공간
      함수가 실행되면 그 함수의 매개 변수, 그 함수의 내부에서 선언된 변수들이 스택공간에 잠시 올라감
      함수가 종료되면 스택 공간에서 빠짐
      값형식의 데이터 변수를 만들면 스택에 올라감<int a =0;>
      클래스의 힙 영역에 올라간 데이터의 주소 변수
      [                                          ][    ][main]
      [Add][Add][Add].......[Add][Add][Add] 함수가 엄청 많으면 "스택 오버플로우"라고 합니다.
     */

    #region 클래스 수업내용
    // 절차 지향
    // 절차란? (1단계 -> 2단계->3단계 x ;; 순서지향(All))
    // procedural programing
    // procedure 프로시저  ==> 함수 중심으로 프로그램을 구조화해서 문제를 해결하는 방식.
    //                         직관적, 간단한 프로그램에 적격

    // 프로그램이 커지거나, 분활더거나 이때부터 무리가 생김..
    // 예) 텍스트 알피지 -> 캐릭터 , 스테이지, 몬스터 싸울지 말지 정하기...
    // 절차지향의 가장 큰 문제점은 순서
    // 함수 호출순서로 문제를 해결. 만약에 꼬이면 함수 로직 자체를 바꿔야 할 수 있다.

    // 객체 지향 (Object -Oriented Programing , OOP )
    // 캐릭터 , 몬스터, 아이템, 보이는 것
    // 스킬, 사운드 안 보이는 것 까지
    // 전부 다 하나의 객체로 각각 만드는 거에요.

    // 자동차를 수리한다.
    // 자동차 
    // ㄴ 엔진. 배터리. 타이어

    // 절차지향은 ' 함수 중심으로 흐름을 만들고 조립하는 방식'이라면
    // 객체지향은 '객체에게 역할을 부여하고, 객체 간 협력을 통해 문제를 해결하는 방식'입니다.

    /*
     * 구조체
     *예 public struct Monster 
    {
        public int orc;

        void Attack()
        {
       // 복잡한 기능은 x
        }
    }
    ** 구조체와 클래스는 메모리 형식이 다름
    구조체 는 값 형식 = 값 = 데이터 / 스택 메모리를 잡으면 그 안에 주소가 아닌 값이 들어간다.
    int a; 
    a = 100; --> 값 형식. [0110][0100][0000][0000]0000000000000000000

    값 전달 : 
    값 형식 :


   ----------------------------------------------------------------------------------------------------------
    @@ 클레스 는 참조 형식 == 주소 공유 = 참조 전달 / 스택 메모리에 그 안에 값이 아닌 주소가 들어간다.
                                                      힙 메모리에 값이 들어간다.
                              인스턴트를 만들어야 그 인스터트에 주소가 들어간다.



     */
    #endregion


    class Player //설정을 만든다. 설계를 만든다. 비유 설계도. 
    {
        // 속성 == 멤버 변수 == 필드 ; 멤버 변수란 플레이어를 설명하는 모든 항목, 어떠한 속성이 있는지. 변수가 무엇인지 설명.
        public int hp; //만약 값이 있으면 다른 함수들 main 또는 start등에서 호출할 때 그 값이 들어간다.
        int str;
        int atk;
        int def; // 값을 지정 안하면 int의 초기값이 0 이 들어감.
        
        // 기능 : 멤버 함수
        void Attack()
        {

        }

        void Skill()
        {

        }

    }

    //static void Main(string[] args) // 시작지점이자 함수.
    //{
    //    // 변수 만듦 -> 스택 메모리
    //    int a;//지역 변수 --> 스택 메모리


    //    Player player = new Player(); // 인스턴스화. 실제 존재하는 무언가를 만드는 것. 객체를 만드는 것 int처럼 새로운 플레이어 타입을 만듬.
    //                                  // 여기서 player.hp = 99;로 값을 지정하면 여기 메인에서는 99로 호출된다. Player player; 여기서 플레이어는 지역 변수.

    //    //주소를 담을 때 운영체제의 비트 만큼 공간을 잡음
    //    // 함수는 = 스택 메모리 player -> [주소값] [000000]000000000[0000]0000000000000000
    //    // 클래스는 힙 메모리 

    //    // 과정)

    //    //[0000][0000][0000][0000]0000000000 --> 객체,지역변수를 만들면 생김. 예를들어 new키워드.
    //    //= new Player(); --> 힙 메모리에 생성.
    //    //[주소값] -->힙 메모리의 = new Player();에 대한 주소가 생성.
    //    // And 함수는 = 스택 메모리 player -> [주소값] [000000]000000000[0000]0000000000000000 <최종>

    #region 값 전달과 참조 전달
    /* 
     * struct Knight
{
    public int hp;
}

class Mage
{
    public int hp;
}

class Program
{
    static void Main(string[] args)
    {
        Knight k1 = new Knight();
        k1.hp = 100;
        Knight k2 = k1;
        k2.hp = 200;

        Mage m1 = new Mage { hp = 100 };
        Mage m2 = m1;
        m2.hp = 300;

        Console.WriteLine($"k1.hp: {k1.hp}"); //100
        Console.WriteLine($"k2.hp: {k2.hp}"); //200

        Console.WriteLine($"m1.hp: {m1.hp}"); //300 
        Console.WriteLine($"m2.hp: {m2.hp}"); //300
    }
    -------------------------------------------------------------------------
    struct Knight
    {
        public int hp;
    }

    class Mage
    {
        public int hp;
    }

    internal class Program
    {
        static void Heal(Knight knight) // 구조체 값 형식
        {
            //Knight.hp == 50

            knight.hp += 10;

            //60
        }

        static void Heal(Mage mage)
        {
            mage.hp += 10;

            //60
        }

        static void Main(string[] args)
        {
            Knight k = new Knight { hp = 50 };
            Mage m = new Mage { hp = 50 };

            Heal(k);
            Heal(m);

            Console.WriteLine($"Knight.hp: {k.hp}"); // 50
            Console.WriteLine($"Mage.hp: {m.hp}");  //60
        }
    }
}
    ---------------------------------------------
    void AddTen(int x)
    {
        x += 10;
    }

    int a = 5;
    AddTen(a);
    Console.WriteLine(a);

    위에 있는 건 값 전달 ( 값 복사) 예시입니다.
    1. 인트 a 라는 변수 만들어서 5라는 값 대입합니다.
    2. AddTen 함수 호출하며 a에 있는 "값:5"를 '복사'해서 전달합니다.
    3. AddTen 함수는 [복사한 값5]를 'x'라고 호칭합니다.
    4. x라고 칭하는 5값에 10을 더합니다.
    5. 15라는 값이 완성되지만 함수가 종료되며 [복사한 값5+=10==15]는 사라집니다.
    6. 즉 인트 a는 필드에서 아무도 건들지 않았으니 그냥 5값 그대로 출력됩니다.

    &&&&&&&&

    void AddTen2(ref int x2)
    {
    x2 += 10;
    }

    int a2 = 5;
    AddTen2(ref a2);
    Console.WriteLine(a2);

    반면에 참조전달은 ( 주소 공유 )
    1. 인트 a라는 변수 만들어서 5라는 값을 대입합니다.
    2. AddTen 함수 호출하며 !! a 변수 그 자체 !!를 전달합니다.
    3. AddTen 함수는 !! 변수 a 그자체!!를 x라고 호칭합니다.
    4. x 라고 칭하는 a에 10을 더합니다.
    5. a 의 5와 10 이라는 값이 더해져서 15 완성합니다.
    6. [a 에 15의 값을 대입]합니다.
    7. 1.에 있는 인트 a를 AdddTen2이 건드렸으니 15값이 출력됩니다.

    enum Test
    {
        A,
        B
    }
    
    값 형식
    enum 열거형 == 값 형식

     | 구분           | 뜻                                   | 예시 비유                                      |
     | ---------      | ------------------------------------ | ---------------------------------------------  |
     | 값 전달 * *    | 값을 "복사해서" 줌 → 원본은 안 바뀜 |“사본을 줌” (복사한 종이 한 장 줌)            |
     | 참조 전달**    | 주소(참조)를 줌 → 원본도 같이 바뀜  |“원본을 줌” (원본 문서를 줘서 거기다 낙서함)|
     */
    #endregion


    class healingPotion
    {
        int heal;
        Player player;

        private void Heal()
        {
            if(player.hp<100) // 단순 hp<10은 null무슨무슨 오류가 뜬다. 1. public으로 바꾸고. Player(클래스) palyer(변수) 로 바꾼다.
            {
             heal += 10;
            }
        }

    }

    
    #region 예제
    //class Knight
    //{
    //    public int hp;
    //    public int atk;
    //}
    //struct Mage
    //{
    //    public int hp;
    //    public int atk;
    //}

    //    static void KillMage(Mage mage) //(ref Mage mage)
    //    {
    //        mage.hp = 0;
    //    }
    //    static void KillKnight(Knight knight)
    //    {
    //        knight.hp = 0;
    //    }
    //    {
    //        Mage mage = new Mage(); // 구조체
    //        mage.hp = 100;
    //        mage.atk = 50;
    //        KillMage(mage);//KillMage(ref mage);

    //        Knight knight = new Knight(); // 클래스
    //        knight.hp = 100;
    //        knight.atk = 50;
    //        KillKnight(knight);

    //        Console.WriteLine($"Mage HP {mage.hp}\nKnight HP {knight.hp}"); //0 //0

    //        // KillMage 함수를 고쳐서 Mage의 값도 0 이 되게 해주세요


    //    }
    #endregion




}


#region 수업내용복습
// 컴퓨터 CPU RAM SSD 요 세가지가 프로그래밍에서 중요하다
// 프로그램의 실행 과정 -> SSD -> RAM -> CPU

// 한줄 주석
/* ㄴㄴㄴ*/
/*
8  4   2   1  8  4  2  1
0  1   1   0  0  1  0  0 = = 100 ;  128,64,32,16,8,4,2,1,순서로 있어서 각 자리에 맞는 수(32자리에 1 있으면)를 더함.
      6          4       = = 64  ;

형변환 3개 외우기. 명시적, 암시적, 스트링인터폴레이션(문자열)

ctrl + kc :주석 할때
ctrl + ku : 주석 풀 떄
ctrl + / : 주석 켜고 풀기

 struct Player // 구조체 변수들을 한꺼번에 사용할려고, 호출할 때 모든 매개변수를 적기 귀찮아서.
        {
            public int Id;
        }

*/
#endregion

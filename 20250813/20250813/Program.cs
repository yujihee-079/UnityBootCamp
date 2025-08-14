
using System.Security.Cryptography;

namespace _20250813
{
    // ========================================================
    // string 관련 함수
    // 문자열 문제!
    // 메인함수 호출부를 보고 CheckId 함수를 만들어주세요!
    // 입력으로 새 아이디(newId)와 기존 아이디(oldId)가 주어진다.
    // 두 아이디를 대소문자 구분 없이 비교해서 같으면 "중복" 출력, 다르면 "사용 가능" 출력
    // Replace를 이용해 새 아이디에 들어 있는 ' '(공백)을 '-'로 바꿔서 출력한다.

    // 조건
    // 공백은 무조건 문자열 안에 0개 또는 1개만 들어온다고 가정
    // 사용할 수 있는 문자열 함수: Contains, IndexOf, ToLower, ToUpper, Replace

    // 메인함수 호출
    // Console.WriteLine(CheckId("Hong GilDong", "hong gildong"));
    // Console.WriteLine(CheckId("Kim", "lee"));

    // 출력예시
    // 중복
    // 사용 가능

    class Program
    {
        static string CheckId(string oldId, string newId)
        {
           //string newId = Console.ReadLine();
           // string oldId = Console.ReadLine(); 값이 있는 상태에서 작성했다고 가정했기에 여기에선 안된다.

            newId = newId.ToLower();
            oldId = oldId.ToLower();
            newId = newId.Replace(' ', '-');
            oldId = oldId.Replace(" ", "-");

            if (newId == oldId)
            {
                return "중복"; // console.writeline이 아니라 리턴 키워드로 반환해야 한다.
            }
            else
            {
                return "사용 가능";
            }

            




        }
        static void Main()
        {
            string name = "Hong GilDog";

            //1. 조회/ 찾기
            bool found = name.Contains("s");

            int a =name.IndexOf("g"); // 3
            int b = name.IndexOf("z"); // 찾을 수 없을 때 -1

            // 2. 변형
            name = name + "power";

            name = name.ToLower(); // all 소문자
            name = name.ToUpper(); // all 대문자
            name = name.Replace('G', 'L'); // all G -> L로 바꾸어라

            // 3. 분리
            string[] names = name.Split(new char[] { ' ' });
            name = name.Substring(3);

            Console.WriteLine(CheckId("Hong GilDong", "hong gildong"));
            Console.WriteLine(CheckId("Kim", "lee"));



        }
    }



    // class Player
    //{
    //    //외부에서 누구나 접근 가능
    //    public int hp;
    //}

    //class Knight : Player
    //{
    //    public static int count = 0;
    //    public int id;

    //    public Knight()
    //    {
    //        id =count++;
    //    }

    //    internal void SecreFunction()
    //    {
    //        //굉장히 중요한 기능

    //    }

    //    //void Test()
    //    //{
    //    //    Player p = new Player();
    //    //    p.hp = -9999;
    //    //}
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Knight knight = new Knight();

    //        knight.id = 0;

    //        Knight.count = 10;

    //        knight.SecreFunction();

    //        Console.Clear();



    //    }
    // 캡슐화
    /*
     * 보안 레벨 == 은닉성

      자동차
       ㄴ> 핸들 조작, 패달 조작, 차문 조작
        ㄴ> 전기장치, 엔진, 연로분사장치 < 사용자 , 외부에 노출 >--> < 사고로 이어질 확률 높아짐 >

        접근지정자(접근제한자)
        Public, protected, private, (internal, proctected internal)

    *public : 
     가장 개방적인 형태
    *private :
     가장 비개방적인(안전한)형태
    예 )

            private hp;
            public void SetHp( int hp )
            {
                this.hp = hp;
            }

            public int Gethp() { return hp; }

    @@ 설명
    Knight 객체 생성시 메모리구조
    [Player] 
    { int hp }
    [Knight]
     { }

    이런식으로 메모리에는 로드 되나 실제 클래스 내부로직에서 hp를 호출하지 못하는것뿐
    그래서 public int Get() {return hp;} 이런식으로 열려진 함수가 있다면
    [Player]  메모리에서 가져와서 그 값을 알려줌
    *protected :
     상속받은 애들만 가능

     은닉성 개념의 캡슐화 <---> 기능 + 데이터를 묶는 개념의 캡슐화 ~ 중요하지 않다
                                목적 : 관련된 데이터와 그 데이터를 다루는 메서드를 한 클래스 안에 묶어서 하나의 "기능 단위"로 만들기

    이미 그런 방식으로 만들고 있어서 ~ 객체 지향 프로그램 특징과 겹침

    //다형성

    같은 이름의 메서드나 인터페이스를 통해 여러 다른 형태를 구현하는 것

    감독 (부모 클래스)
            ㄴ 촬영지침 (가상에서도 )












    -----문제-----
    문제1.

using System;

class Player
{
public int hp = 100;
}

class Program
{
static void Main()
{
    Player p = new Player();
    p.hp = -9999;            // (L1)
    Console.WriteLine(p.hp); // (L2)
}
}

질문: 이 코드는 실행되나? 된다면 (L2) 출력은?
추가: 이 상황을 캡슐화로 막으려면 어떤 접근 지정자/방법을 써야 하는가? (키워드만)

---

문제2.
using System;

class Player
{
private int hp = 100;
}

class Program
{
static void Main()
{
    Player p = new Player();
    p.hp = 10;               // (L1)
    Console.WriteLine("OK"); // (L2)
}
}

질문: 컴파일/실행되나? 안 되면 에러 라인과 이유를 짧게 적어라.

---

문제3.

using System;

class Player
{
protected int hp = 100;
}

class Knight : Player
{
public void HitMe(int dmg)
{
    hp -= dmg;               // (L1) ← 여기 접근 가능?
}
}

class Program
{
static void Main()
{
    Knight k = new Knight();
    k.HitMe(30);
    Console.WriteLine(k.hp); // (L2) ← 여기 접근 가능?
}
}

질문: (L1), (L2) 각각 컴파일되나? “가능/불가 + 한 단어 이유(접근자)”로 답하라.

---

문제4.

using System;

class Player
{
public static int Count = 0;
public Player() { Count++; }
}

class Program
{
static void Main()
{
    new Player();
    new Player();
    Player.Count = -123;      // (L1)
    Console.WriteLine(Player.Count); // (L2)
}
}

질문: 실행되나? 된다면 (L2) 출력은?
추가: 캡슐화로 이 문제를 막으려면 어떤 방식(예: 메서드 또는 접근 지정자)을 써야 하는가? (키워드/아이디어만)
    ----------------------
    1. L(2) 출력은 -9999, 키워드로 private, public
    2. Private는 클래스 플레이어에서만 실행되는 실행문이기 때문입니다.
    3. (L1) 접근가능 (L2)접근불가능 이유 protected 보안 이 다르기 때문/ program 에서 상속이 이루어지지 않았기 때문이다.
    4. (L2)실행가능 -123. 매개변수가 없는 함수이기 때문입니다. -122가 출력되기 싫으면 protected로 변수 앞에 씁니다

    ---------------------다향성-------------------
    @@ 각 항목별로 출력값을 적어보시오.
    class Player
{
public virtual void Move()
{
    Console.WriteLine("Player.Move");
}
}

class Knight : Player
{
public override void Move()
{
    Console.WriteLine("Knight.Move");
}
}

class Mage : Player
{
public override void Move()
{
    Console.WriteLine("Mage.Move");
}
}

class Program
{
static void Main()
{
    Player p1 = new Knight();
    Player p2 = new Mage();
    p1.Move();
    p2.Move();
}
}


문제2.
class Player
{
public void Move()
{
    Console.WriteLine("Player.Move");
}
}

class Knight : Player
{
public new void Move()
{
    Console.WriteLine("Knight.Move(new)");
}
}

class Program
{
static void Main()
{
    Player p = new Knight();
    Knight k = new Knight();
    p.Move();
    k.Move();
}
}


문제3.
class Player
{
public virtual void Move()
{
    Console.WriteLine("Player.Move");
}
}

class Knight : Player
{
public override void Move()
{
    Console.WriteLine("Knight.Move(enter)");
    base.Move();
    Console.WriteLine("Knight.Move(exit)");
}
}

class Program
{
static void Main()
{
    Player p = new Knight();
    p.Move();
}
}
    1.Knight.Move 
    Mage.Move
    2.Player.Move
    Knight.Move(new)
    3.Knight.Move(enter)
    Player.Move
    Knight.Move(exit)
     */


}


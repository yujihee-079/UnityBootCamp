 namespace _20250806
{
    // 생성자 (Constructor)
    /*
     * public Knight()
     * {
     *   Kinght 타입의 객체를 힙에 생성
     *   힙 메모리
     *   [ 0000 0000 0000 0000 ][ 0000 0000 0000 0000 ]
     *   hp = 0;
     *   atk = 0;
     *   return Knight 타입의 객체
     *   main에서 호출. Knight() //  Knight.hp
     *   
     *   오버로딩 : 함수 이름 재사용, 매개변수를 바꿔준다.
     *   
     *   this = 클래스의 주인 . Knight
     *   
     *  // =======================================
        // 1. Wizard 클래스를 만들어 다음 조건을 만족하세요:
        // 
        // - 멤버 변수: mp, intelligence (둘 다 int형)
        // - 기본생성자에서 각각 50, 20으로 초기화
        // - Main()에서 Wizard 객체를 생성하고 두 값을 출력
        //
        // [실행 결과]
        // 마법사의 MP: 50, 지능: 20
        // =======================================
    내가 한 풀이 
     public class Wizard()
    {
        public int mp = 50;

        public int inetlligence =20 ;

        

    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Wizard wizard = new Wizard();

            Console.WriteLine($"마법사의 mp : {Wizard.} , 지능{Wizard}");
        }
    }

    코드가 실행되는 올바른 예시
    class Wizard
{
    public int mp;
    public int intelligence;

}
    public Wizrd()
    {
      mp = 50;
      intelligence = 20;
    }
    static void Main(string[] args)
    {
     Wizard wizard = new Wizard();

        Console.WriteLine($"Wizard: HP {wizard.mp}, ATK {wizard.intelligence}");
    }

    // =======================================
    // 2. Archer 클래스를 만들어 다음 조건을 만족하세요:
    //
    // - 멤버 변수: hp, dexterity
    // - 기본 생성자: hp = 70, dexterity = 30
    // - 매개변수 생성자: 외부에서 전달받은 값으로 초기화 (90, 45)
    // - Main()에서 두 가지 생성자로 객체를 생성하고 각각 출력
    //
    // [실행 결과]
    // 기본 궁수: HP 70, 민첩성 30
    // 커스텀 궁수: HP 90, 민첩성 45
    // =======================================
    답안
    public class Archer
    {
        int hp;
        int dexterity;



        public Archer()
        {
            hp = 70;
            dexterity = 30;
        }

        public Archer(int hp, int dexterity)
        {
            this.hp = hp;
            this.dexterity = dexterity;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Archer archer = new Archer();
                Archer customarcher = new Archer(90,45);

                Console.WriteLine($"기본 궁수 HP: {archer.hp}, 민첩성{archer.dexterity}");
                Console.WriteLine($"커스텀 궁수 Hp:{customarcher.hp}, 민첩성 {customarcher.dexterity}");
            }
        }


    }
}


    // =======================================
    // 4. Paladin 클래스에서 생성자 체이닝을 사용하세요:
    //
    // - 멤버 변수: hp, atk, def
    // - 기본 생성자: def = 5, "기본 생성자 호출" 출력
    // - 매개변수 생성자: hp, atk를 받아서 설정 + this()로 기본 생성자 호출
    //
    // [실행 결과]
    // 기본 생성자 호출
    // 커스텀 생성자 호출
    // 성기사 - HP: 150, ATK: 30, DEF: 5
    // =======================================
     public class Paladin
    {
        int hp;
        int atk;
        int def;



        public Paladin()
        {
            
            def = 5;
            Console.WriteLine("기본 생성자 호출");
        }

        public Paladin(int hp, int atk) : this()
        {
            this.hp = hp;
            this.atk =  atk;
            Console.WriteLine("커스텀생산자호출");
        }

        internal class Program
        {
            static void Main(string[] args)
            {
               Paladin archer = new Paladin();
               Paladin customarcher = new Paladin(150,30);

                Console.WriteLine($"기본 궁수 HP: {archer.hp}, 민첩성{archer.atk}");
                Console.WriteLine($"커스텀 궁수 Hp:{customarcher.hp}, 민첩성 {customarcher.atk}");
            }
        }


    }

    // =======================================
// 7. Wizard 클래스와 MagicType 열거형(enum)을 활용하세요:
//
// - Wizard 클래스에는 mp(마나)와 intelligence(지능)가 있음
// - 생성자에서 mp = 100, intelligence = 30으로 초기화
//
// - MagicType 이라는 enum을 정의:
//   Fireball = 1 (MP 20 소모)
//   Icebolt = 2 (MP 15 소모)
//   Heal = 3 (MP 10 소모)
//
// - CastSpell(MagicType magic) 메서드 작성:
//   마법 종류에 따라 마나를 차감하고 Console에 어떤 마법을 썼는지 출력
//   마나가 부족하면 “마나가 부족합니다.” 출력
//
// - Main()에서 Fireball, Heal 순서로 시전하세요.
//
// [실행 결과]
// Fireball 시전! 마나가 20 줄어듭니다.
// Heal 시전! 마나가 10 줄어듭니다.
// 남은 마나: 70
// =======================================
    public class Wizard
    {
        int mp;
        int intelligence;




        public Wizard()
        {

            mp = 100;
            intelligence = 30;

        }
        public enum MagicType
         {
              Fireball = 1,
              Icebolt = 2  ,
              Heal = 3      
         }      

        public void CastSpell(MagicType magic)
        {
            int cost = 0;
            string spellname = "";

            switch (MagicType)
            {
                
            }




            //switch ((int)magic)
            //{
            //     case 1
            //        : Console.WriteLine(mp -= 10);
            //        break;
            //        case 2 : Console.WriteLine(mp -= 15);
            //        break;
            //        case 3 : Console.WriteLine(mp -= 10);
            //        break;
            }
           

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard();
            

            Console.WriteLine();
            
        }
    }




    }
    ---------------------------------------------------------------
    구조체 
    생성자를 만들 수 있고, 오버로딩도 가능하다.

    필드. 멤버변수, 지역 변수


    class Knight
    {
        // 필드 (멤버변수)
        // Knight에 포함된 데이터
        public int hp;
    }

    지역 변수
    어떠한 특정 함수 내에서 그 지역안에서만 속해있는 변수를 말한다. 
    예) class Program
        Main() { int a; <----  지역 변수 }

    생명 주기
    예 )
    
    멤버 함수, 지역 함수
    멤버 > 지역.
    지역 함수는 특정 함수 내부에 있어서 그 지역 밖으로 호출 할 수 없다.
    지역 함수는 접근 지정자 붙일 수 없음. 퍼블릭, 프라이빗, 프로텍티드

    // =======================================
    // [문제]
    // Knight와 Monster 클래스를 정의하고,
    // 필드, 지역 변수, 멤버 함수, 지역 함수의 차이를 이해하고 사용하세요.
    //
    // [요구사항]
    // 1. Monster 클래스에는 name(string), hp(int)를 필드로 선언하세요.
    // 2. Knight 클래스에는 name(string), atk(int)를 필드로 선언하고,
    //    Attack(Monster target)이라는 멤버 함수를 정의하세요.
    // 
    // 3. Attack 함수 내부에 지역 함수 DamageLog(int damage)를 만들어,
    //    Console에 “{몬스터 이름}에게 {데미지}의 피해를 입힘”을 출력하세요.
    // 
    // 4. Attack 함수에서는 지역 변수 damage(int)를 선언하고,
    //    Knight의 atk 값을 대입한 후,
    //    Monster의 hp를 감소시키고, 지역 함수로 로그를 출력하세요.
    //
    // 5. Main()에서 Knight와 Monster 객체를 생성하고,
    //    Knight가 Monster를 공격하도록 하세요.
    //
    // [실행 결과 예시]
    // 아서가 고블린에게 30의 피해를 입힘
    // 고블린의 남은 체력: 70
    // =======================================
    내가 풀이하려 한 것
    public class Knight
    {
        string name ="";
        int hp;

        void Attack(Monster targer)
        {
            int damage;

            Knight.atk
              int  DamageLog(int damage)
            {
                Console.WriteLine($"{name}에게 {damage}의 피해를 입힘");
            }
               
        }

    }

    public class Monster
    {
        string name = "";
        int hp;

        public Monster()
        {
            string name;
            int hp;
        }

    }
     ===============================================================================
    실제 작용되는 코드
     class Knight
    {
        public string name;
        public int atk;


        public void Attack(Monster target)
        {
            int damage = atk;
            void DamageLog(int damage)
            {
                target.hp -= atk;
                Console.WriteLine($"{name}가 {target.name}에게 {damage}의 피해를 입힘");
                Console.WriteLine($"{target.name}에게 {damage}의 피해를 입힘");
                Console.WriteLine($"{target.name}의 남은 체력:{target.hp}");
            }
            DamageLog(damage);
        }
    }

    class Monster
    {
        public string name;
        public int hp;
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Monster monster = new Monster();
            knight.name = "아서";
            knight.atk = 30;
            monster.name = "고블린";
            monster.hp = 100;
           knight.Attack(monster);
            
        }
    }
}



    // 설계도 게임, 소설 
    // 주인공 : 남자답게 생김, 검술 max
    // 실제로 소설에 등장한 것이 아니다.

    // 소설
    // 주인공이 길을 떠났다. -> 생명을 불어 넣는다.
    // 객체를 생성               프로그래밍 
    // Knight.knight = new knight();
    // 스태틱을 붙이면 더이상 객체에 종속적이지 않다. 접근하지 않는다.
    // 공통으로 사용하는 변수
    // 왜 공통으로 사용하냐 , 코드 만들 때 
    // 정적 변수. <- 정적 함수안에 객체를 넣으면 안됨.

    // 필드 (멤버변수) , 지역 변수
    class Knight
    {
        // 필드(=멤버변수)
        // Knight에 포함된 데이터
        public int hp;
        public int atk;
        public string name;

        // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values

        void Test()
        {
            // 지역 변수
            hp = 0;
            int a;

            {
                // 지역 변수
                int b = 0;
            }
        }

        public void Attack(int damage)
        {
            int result = hp - damage;
            Console.WriteLine($"{damage}만큼의 피해를 입었습니다.");
        }

        // 구분		    |	필드(Field)								    | 지역 변수(Local Variable)
        //--------------|-----------------------------------------------|-----------------------------------
        // 선언 위치	|	클래스 안쪽						            | 메서드, 생성자, 코드 블록 안
        // 생명 주기	|	객체 생성 → 객체 소멸까지 유지				| 메서드 실행 → 메서드 종료 시 사라짐
        // 접근 범위	|	클래스 내부 전체							| 해당 블록 내부에서만 사용 가능
        // 초기화	    |	자동 초기화됨 (int는 0, bool은 false 등)	| 반드시 직접 초기화해야 함 (안 하면 에러)
        //--------------|-----------------------------------------------|-----------------------------------
    }



    class Program
    {
        static void Main(string[] args)
        {
            // 지역변수
            int a = 0;


            Knight knight = new Knight();
            Knight knight1 = new Knight();
            Knight knight2 = new Knight();
            Knight knight3 = new Knight();

            // knight  [hp][atk][name]
            //         [hp][atk][name]
            // knight2 [hp][atk][name]
            // knight3 [hp][atk][name]

            // 가비지컬랙터 -> 연결이 안되어있는 아무도 사용하지않는 객체를 삭제 시켜버림
        }
    }
}
 
 */

    /*
     namespace CSharp
    {
        // 멤버 함수, 지역 함수
        class Knight
        {
            public int hp;
            public int atk;
            public string name;


            public Knight()
            {

            }

            // 멤버 함수
            public void Test()
            {
                hp = 0;
            }

            // 멤버 함수
            public void Attack(int damage)
            {
                int a = 0;

                hp = 0;
                // 지역함수
                void Test2() //접근 지정자 붙일수 없음 : 퍼블릭, 프라이빗, 프로텍티드
                {
                    int result = hp - damage;
                    //
                    //
                    //
                    a = 0;
                }

                Test2();
                Test2();
                Test2();
                Test2();

                Console.WriteLine($"{damage}만큼의 피해를 입었습니다.");
            }


            //				멤버 함수(Member Method)			|	지역 함수 (Local Function)
            //----------|---------------------------------------|--------------------------------------------------
            //선언 위치 |	클래스 안쪽				            |	함수(메서드) 안쪽
            //호출 방법 |	객체명.함수명()으로 호출		    |	선언된 함수 안에서만 함수명()으로 호출
            //접근 범위 |	클래스 전체의 필드에 접근 가능   	|	선언된 함수와 그 함수의 모든 변수에 접근 가능
            //사용 목적 |	객체의 기능을 정의하고 외부에 제공	|	특정 함수 내의 복잡한 로직을 분리하여 가독성을 높임
            //----------|---------------------------------------|---------------------------------------------------

        }



        class Program
        {
            static void Main(string[] args)
            {
                Knight knight = new Knight();
                knight.Attack(10);

            }
        }
    }


        // =======================================
        // [문제 1] Knight 클래스에서 static 변수와 static 함수를 사용해보세요.
        //
        // [요구사항]
        // 1. Knight 클래스에 다음과 같은 필드를 선언하세요:
        //    - static int count → 생성된 Knight의 수를 추적 (초기값 0)
        //    - int id → 각 기사의 고유 번호 (count를 이용해 설정)
        //    - int hp → 기사 체력 (생성자에서 100으로 초기화)
        //
        // 2. 생성자에서:
        //    - id는 count 값을 그대로 넣고,
        //    - count를 1 증가시키세요.
        //    - hp는 100으로 초기화
        //
        // 3. public void Info() 함수를 만들어 기사 정보를 출력하세요:
        //    → "기사 ID: {id}, 체력: {hp}"
        //
        // 4. public static void ResetCount() 함수를 만들어 count를 0으로 초기화하세요.
        //
        // 5. Main() 함수에서 기사 2명을 생성하고 Info()를 출력한 후,
        //    static 함수 ResetCount()를 호출하고,
        //    Knight.count를 출력하세요.
        //
        // [실행 결과]
        // 기사 ID: 0, 체력: 100
        // 기사 ID: 1, 체력: 100
        // 현재 Knight 수: 2
        // Knight 수 초기화!
        // 현재 Knight 수: 0
        // =======================================
        // tcp , 넷코드.
        */
    class Knight
    {
        static public int count = 0;

        public int id;
        public int hp;

       public Knight()
        {
            this.id = 0;
            count++;
            hp = 100;
        }

        public void Info()
        {
            Knight id = new Knight();
            Knight hp = new Knight();
            Console.WriteLine($"기사 {id}, 체력{hp}");
            

        }

        public static void ResetCount()
        {
            count = 0;
            Console.WriteLine("Knight 수 초기화!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight1 = new Knight();
            Knight knight2 = new Knight();
            knight1.Info();
            knight2.Info();
            Console.WriteLine($"현재 Knight 수: {Knight.count}");
            Knight.ResetCount();
            Console.WriteLine($"현재 Knight 수: {Knight.count}");

        }
    }
    
}



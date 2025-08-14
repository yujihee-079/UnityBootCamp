using System.Xml.Linq;

namespace _20250812
{
    

    class Player // 상위 클래스
    {
        /*
         * OOP의 4가지 특성
        추상화 : 공통 속성을 하나의 개념으로 묶는 것
        캡슐화 : 내부 정보를 숨기고 외부에 필요한 기능만 제공 / 예 가루약 내부.
        상속   : 기존 클래스를 물려받아 코드 재사용
        다형성 : 같은 함수를 다양한 행동을 할 수 있게 함

        "클래스" 몸 속에 4가지 특성이 유기적으로 연결되어 있다.
        OOP의 4가지 특징은 " 클래스 " 안에서 돌아감

        int a = 10; 단순한 변수는 객체가 아님!!

        추상화  : 설계의 시작점
        1. 여러 설계도간의 공통점을 추려냄
        2. 추려낸 공통점을 하나의 상위 개념으로 정리
        3. 추상 클래스나 인터페이스 표현
        4. 클래스는 현실을 코드로 모델링하는 도구
        예제 ) Knight, Mage, Acher --> 상위개념 Player

        class Knight {
        int hp; }......

        ===> class Player{    ---> 베이스 설계도!! 실존하지 않지만 , 공통 클래스의 몸체가 된다.
        int hp;}

        class Knight : Player{}
         
        상속 : 공통된 구조를 재사용
        추상화로 정의된 베이스 클래스를 기반으로, 하위 클래스가 물려받아 사용

        다형성 : 같은 이름, 다른 행동
        상속을 받은 여러 클래스들이 같은 메서드를 각자 다르게 구현할 수 있음

        캡슐화 : 안전하고 통제된 사용, 보안 레벨
        1. 내부 로직이나 데이터를 외부에는 숨김
        2. 공개된 메서드를 통해서 접근 할 수 있게 함.

        OOP는 단지 기능이 많은 코드를 짜는게 아니라, 변화에 강하고, 유지 보수하기 쉽고, 협업하기 좋은 구조
        
        절차 지향에서 불편한점
        1. 똑같은 코드를 여러 번 서야 함
        2. 기능이 많아질수록 코드가 길어짐
        3. 수정할 때 모든 함수에 영향 감
        4. 코드를 읽기 어려워짐
        5. 확장하거나 새로운 기능 넣기 어려움

        ----------------------------------------

        객체지향에서는 이렇게 해결 됨
        1. 공통 속성을 상위 클래스에 넣고, 상속으로 재사용 가능
        2. 객체 단위로 쪼개고 각 객체가 자기 일만 처리하게 만듦
        3. 캡슐화 덕분에 클래스 내부만 바꾸면 됨
        4. 객체 단위로 구조화 되어 가독성 향상
        5. 기존 클래스 건드리지 않고 새 객체만 만들면 됨 (확장성)

        ----------------------------------------------
        추상화
        복잡한 걸 단순하게, 본질만 남기자
        공통된 것만 뽑아서 하나로 만들자
        
        구분              | 일반 클래스(`class`)               | 추상 클래스(`abstract class`) 
         ------------------|------------------------------------|------------------------------------
        인스턴스 생성     | 가능 (`new ClassName()`)           | 불가능(`new AbstractClass()`) 
        메서드 구현 여부  | 모든 메서드는 구현이 되어야 함     | 일부 메서드는 미구현(추상 메서드)로 둘 수 있음
        목적              | 실제 기능을 가진 구체적 설계도     | 공통 설계와 규칙만 정의하는 추상적 설계도

        추상클래스 특징 미완성 코드. 
        ex) public abstract void UseSpecialSkil(); // 구현이 안됨, 자식은 무조건 오버라이드 강제.

        추상의 핵심 -> 강제성을 위해. 



        공식문서 
        https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members
        구체적 예시
    ----------------------------------------------------------------------------------------------------------
     abstract class Player
    {
        public int hp;
        public int mp;

        public abstract void Attack(); // 강제
    }

    class Knight : Player
    {
        public override void Attack()
        {
            Console.WriteLine("기사의 공격!");
        }

        class Mage : Player
        {
            public override void Attack()
            {
                Console.WriteLine("마법사의 공격!");
            }
        }

        class Archer : Player
        {
            public override void Attack()
            {
                Console.WriteLine("마법사의 공격!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Knight knight = new Knight();
                Mage mage = new Mage();
                Archer archer = new Archer();  // 객체 생성

                knight.Attack();   
                mage.Attack();
                archer.Attack();               // 호출 

                int a = 10;
                string name = "홍길동";
                bool isAlive = true;
            }
        }
    }
    =====================================================================================================================
        상속은 부모의 속성과 기능을 그대로 물려받아 사용
        콜론 : 을 사용
        부모 클래스 = 기반 클래스 = 베이스 클래스
        자식 클래스 = 하위 클래스 = 파생 클래스
        재정의 -> 부모 virtual / 자식 override 키워드 사용
        this == 나 자신
        base == 부모.

        @@ class 자식클래스 : 부모클래스
       

        [player 영역]


    

        상속은 2-3단계가 적당합니다
        잘못된 상속
        class Vehicle
        class Animal : Vehicle
        완전히 다른 존재인데 상속. 중복되는 hp 속성이어서 오해할 수 있습니다.

        -------------- 생성자 ---------------------------------
        매개변수가 있는 클래스의 상속
        자식 클래스에서 반드시 base 키워드를 써서 만들어야 한다.
        부모의 매개변수가 있는 것을 호출해야 한다.
        자식 클래스 생성자 호출전에 부모 클래스 생성자를 호출합니다.
        
        
        클래스 형식 변환 
        is 또는 as 문법을 사용한다.
        -------- 문제 ----------------------
         is 연산자는 형변환을 시도하고, 실패하면 null을 반환한다. (O / X)
        bool이니까 실행문을 실행하지 않음

    as 연산자는 타입이 맞는지 확인하여 true 또는 false를 반환한다. (O / X) 
        // bool 이 is니까 x
        형식 자체를 참조. 
        
        
         */
        public int hp;
        public int atk;

        public void Attack()
        {
            Console.WriteLine("칼을 휘드른다!");
        }
    }

    class Knight : Player
    {

    }

    class Mage : Player
    {

    }
    class Program
    {
        

        
    }

    /*
     문제)
    당신은 동물원 시스템을 만들고 있는 개발자입니다.
    동물들은 공통적으로 이름을 가지고 있으며, 각자 고유한 울음소리를 냅니다.
    부모 클래스 Animal은 추상 클래스이며, 모든 동물은 이 클래스를 상속받아야 합니다.

    구현 조건
    
    추상 클래스 Animal을 만드세요.
    string Name 필드를 가짐
    생성자에서 "안녕하세요, 저는 [이름]입니다" 출력
    abstract void MakeSound(); 추상 메서드를 선언
    void virtual MakeSound()
    자식 클래스는 이 클래스를 상속받아서 재정의 해주세요

    
    다음 세 개의 클래스를 만들고 Animal을 상속받으세요.
    Dog → "멍멍!" 출력
    Cat → "야옹~" 출력
    Cow → "음머~" 출력
    ※ 각 동물의 소리는 MakeSound() 메서드 오버라이딩을 통해 구현합니다.

    
    Main() 함수에서 각각의 동물을 생성하고, MakeSound()를 호출하세요.


    [출력예시]
    안녕하세요, 저는 댕댕이입니다
    멍멍!

    안녕하세요, 저는 나비입니다
    야옹~

    안녕하세요, 저는 해피카우입니다
    음머~
     */

      class Animal()
    {
        public string Name;

        //void virtual MakeSound();
        //public Animal() :this() 생성자
        //{
        //    Console.WriteLine($"안녕하세요, 저는 {name}입니다");
        //}
        public Animal(string name) :this()
        {
            Console.WriteLine($"안녕하세요, 저는 {name}입니다");
        }

        public virtual void MakeSound()
        { }

        public virtual void Animalname()


    }

    

    class  Dog() : Animal
    {
        public Dog(string name) : base(name)
        { }
        public override void MakeSound() 
        {
            Console.WriteLine("멍멍!");
        }
        public override void Animalname()
        {
            Name = "골든댕댕이";
        }
       
    }

    class Cat() : Animal
    {
        public Cat(string Name) : base(Name)
        { }
        public override void MakeSound()
        {
            Console.WriteLine("야옹~");
        }
        public override void Animalname()
        {
            Name = "나비";
        }
    }

    class Cow() : Animal
    {
        public Cow(string Name) : base(Name) 
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("음머~");
        }
        public override void Animalname()
        {
            Name = "해피카우";
        }

    }

    
       static void Main(string[] args)
        {
            Dog dog = new Dog("강아지");
            dog.MakeSound();
            Cat cat = new Cat("고양이");
            cat.MakeSound();
            Cow cow = new Cow("소");
            cow.MakeSound();

        }

    }
}

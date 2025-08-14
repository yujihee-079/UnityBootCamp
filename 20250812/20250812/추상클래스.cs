using static System.Net.Mime.MediaTypeNames;

namespace _20250806
{
    // OOP는 단지 기능이 많은 코드를 짜는 게 아니라, 변화에 강하고, 유지보수하기 쉽고, 협업하기 좋은 구조

    // 절차지향에서 불편했던 점	            ->  객체지향에서는 이렇게 해결됨
    // ------------------------------------------------------------------------------------------
    // 똑같은 코드를 여러 번 써야 함	    ->  공통 속성을 상위 클래스에 넣고, 상속으로 재사용 가능
    // 기능이 많아질수록 코드가 길어짐	    ->  객체 단위로 쪼개고, 각 객체가 자기 일만 처리하게 만듦
    // 수정할 때 모든 함수에 영향감	        ->  캡슐화 덕분에 클래스 내부만 바꾸면 됨
    // 코드를 읽기 어려워짐	                ->  객체 단위로 구조화되어 가독성 향상
    // 확장하거나 새로운 기능 넣기 어려움	->  기존 클래스 건드리지 않고 새 객체만 만들면 됨 (확장성)

    // 추상화(Abstraction) -> 클래스는 현실을 코드로 모델링하는 도구
    // 복잡한 걸 단순하게, 본질만 남기자
    // 공통된 것만 뽑아서 하나로 만들자

    // 핸들 돌리면 방향이 바뀌고
    // 액셀을 밟으면 앞으로 나가고

    // 구분              | 일반 클래스(`class`)               | 추상 클래스(`abstract class`)           
    // ------------------|------------------------------------|------------------------------------ 
    // 인스턴스 생성     | 가능 (`new ClassName()`)           | 불가능(`new AbstractClass()`) 
    // 메서드 구현 여부  | 모든 메서드는 구현이 되어야 함     | 일부 메서드는 미구현(추상 메서드)로 둘 수 있음
    // 목적              | 실제 기능을 가진 구체적 설계도     | 공통 설계와 규칙만 정의하는 추상적 설계도  


    // 추상클래스의 핵심 -> 강제성을 위해
    // https://learn.microsoft.com/ko-kr/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members

    abstract class Player
    {
        public int hp;
        public int mp;

        public abstract void Attack();
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
                Archer archer = new Archer();

                knight.Attack();
                mage.Attack();
                archer.Attack();

                int a = 10;
                string name = "홍길동";
                bool isAlive = true;
            }
        }
    }
}


using System.Runtime.InteropServices;

namespace _20250825
{
    #region delegate
    /*{ 
        // delegate 대리자
        //콜백을 가능하게 해주는 도구
        // 함수 자체를 인자로 넘겨주는 방식

        // 퀵서비스
        // 연락처 넘김
        // 도착하면 연락함

        // 함수를 매게변수로 넘겨주는 방식


        class Program
        {
            // delegate : 형식은 형식인데, 함수 자체를 인자로 넘겨주는 형식.
            // 반환 : int, 입력: void
            // OnClicked 이 delegate 형식의 이름
            delegate string OnClick();
            delegate void OnClick2();

            // UI - Button button;
            // button.onClick. AddListecer();

            //  int = 정수 형식
            // OnClick = 인트 반환하고 매개변수 안 받는 형식

           int[] 배열 =  [60, 30, 20, 10, 40 ,50]






            static void ButtonEvent(OnClick onClick)
            {
                // UI 로직

                Attact();
                //콜 백
                onClick();


            }
            //static void ButtonEvent()
            //{
            //    // UI 로직

            //    Attact();
            //    //콜 백


            //}



            static int Test()
            {
                Console.WriteLine("이건 넘겨주는 함수야");
                return 0;
            }

            private static void Attact()
            {
                // 플레이어 공격
                // 점프
                // 화장실 가기
            }

            static void Main(string[] args)
            {
                ButtonEvent(Test);
            }
        }
    }*/
    #endregion

    #region Action
    /*
    class InputManager
    {
        public Action<int, int> Action;

        public void update()
        {
            Action.Invoke(10, 20);
        }
    }
    class Program
    {
        #region 앞부분 내용 일부
        // Action = 반환값이 존재하지 않는 델리게이트에 대해서 C#언어차원에서 미리 만들어둔 키워드 이다.
        // Action 은 매개변수를 최대 16개 까지 받을 수 있도록 만들어 놨음
        // Action 은 void 형식의 델리게이트를 미리 언어차원에서 선언해둔 것
        // 외부에서도 이 액션에 대해서 Invoke를 통해서 호출해 줄 수 있다.
        // delegate void Action(int a);

        //// delegate void Action(int a , int b); 아래랑 똑같은 것
        //public Action<int  , int> action;

        // public void Update()
        // {
        //     Action.Invoke(10, 20); ;
        // }
        // static void Main(string[] args)
        // {

        // }
        #endregion

        static void Test(int a, int b)
        {
            Console.WriteLine(" C # 은 너무나 행복하고 즐겁다 ! 웃음이 절로 난다 하하하");
        }

        static void Main()
        {
            InputManager inputManager = new InputManager();
            inputManager.Action += Test;

            inputManager.Action.Invoke(10, 20);
            // inputManager. InputKey. Invoke();

            while (true)
            {
                inputManager.update();
            }
        }
    }*/
    #endregion


    class Item()
    {
        public enum ItemType
        {
            Weapon,
            Armor,
            Amulet,
            Ring
        }

        public enum Rerity
        {
            Normal,
            Uncommon,
            Rare
        }

        public ItemType itemType;
        public Rerity rerity;


        
       
    }
    
    class Program
    {
        // lambda = 일회용 함수 만드는 방법
        // 식 본문 멤버(Expression-bodied member)

        // 람다연산자, 람다 오퍼레이터
        // FindItem((Item item) => item.itemType == ItemType.Weapon );

        //반환값이 있는 미리 만들어둔 델리게이트
        Func<int, int> func = (int x) => x;

        public static List<Item> _items = new List<Item>();
        delegate bool ItemSelector(Item item);
        static Item FindItem(ItemSelector selector) // item 클래스에 있으면 static 키워드 때문에 오류가 뜬다
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return item;
            }
            return null;
        }
        static void Main(string[] args)
        {
            
            List<Item> _items = new List<Item>();

            _items.Add(new Item() { itemType = Item.ItemType.Weapon, rerity = Item.Rerity.Normal});
            _items.Add(new Item() { itemType = Item.ItemType.Armor, rerity= Item.Rerity.Normal});
            _items.Add(new Item() { itemType = Item.ItemType.Ring , rerity = Item.Rerity.Normal});

            Item weapon =FindItem(delegate (Item item) { return item.itemType == Item.ItemType.Weapon; });
            Item armor = FindItem(delegate (Item item) { return item.itemType == Item.ItemType.Armor; });
            Item ring = FindItem(delegate (Item item ) { return item.itemType == Item.ItemType.Ring; });

            FindItem((Item item) => item.itemType == Item.ItemType.Weapon);
        }
    }
}
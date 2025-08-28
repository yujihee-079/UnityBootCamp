using System;

namespace 자료구조 
{
    class Player
    { 
    }

    class Monster
    {
        public int hp;

        public int id;
        public Monster (int id)
            { this.id = id; }
    }
    class _10일차
    {
        /*
          배열 = 같은 종류의 데이터를 한줄로 묶어놓은 연속된 저장공간
         일반 배열 = 고정된 배열 --> 크기를 수정하지 못한다.
         배열은 참조 형식이다.

        int [] a = new int[6]
         a = new int[7]
        정리 : 아예 새로운 배열을 만들고 변수의 참조를 변경, 기존 배열은 메모리 어딘가에 남아있다가 GC에 의해서 나중에 삭제됨

        int, flaot, bool = 값 그자체 저장됨 =값형식 배열
        class, array = 힙영역에 생성, 그 주소가 스택에 저장됨 = 참조형식 배열

         for eacg는 읽기 전용 반복문입니다.
         엘리먼트는 읽기전용이라 변경이 불가능하다
         값 형식은 엘리먼트 자체에 값이 들어가있어 변경 불가
         참조 형식은 엘리먼트가 주소이기에 그걸 타고 들어가서 내부 필드에 접근하여 내부 필드는 값의 변경이 가능합니다.
         단순 조회, 출력, 합계, 검색에 최적화.
         그래서 데이터를 읽기만 할 때는 foreacg 유용하다
         배열의 요소를 수정해야 할 때는 for 문을 사용
        */

        struct Mystruct
        {
            int a;
            int b;
            //[a][b]
        }
        //static void main()
        //{
        //    int[] c = new int[6] { 10, 20, 30, 40, 50, 60 };
        //    // int[] c = new int[] { 10, 20, 30, 40, 50, 60 };
        //    // int[]c  =  { 10, 20, 30, 40, 50, 60 };
        //    // b [10] [20] [30] [40] [50] [60]
        //    int[] array = new int[6];//배열 만들기 공간설정 --> a [0] [0] [0] [0] [0] [0]
        //    array[0/*인덱스*/] = 1; //값 쓰기
        //    int b = array[0/*인덱스*/]; // 값 읽기

        //    // foreach 는 읽기 전용
        //    // foreach 받아온 개별 엘리먼트는 수정을 할 수 없음
        //    foreach (int item in array)
        //    {
        //        // item = 10; 수정 x
        //        int temp = item;
        //        Console.WriteLine(item);
        //    }

        //    for (int i = 0; i < 6; i++)
        //    {
        //        array[i] = i;
        //    }
        //}
        void test()
        {
            // monster.Length == 배열의 길이.
            int[] a = new int[6];

            // a [] [] [] [] [] []
            //   0  1  2  3  4  5  
            a[0] = 10;

            for (int i = 0; i < 6; i++)
            {
                a[i] = i;

                //a [0][1][2][3][4][5]
            }

            int[] b = { 10, 20, 30, 40, 50, 60 };

            // b[10][20][30][40][50][60]

            Monster[] monsters = new Monster[3];
            // heap [null] [null] [null]

           // monsters[0] = new Monster();
            // heap [ Monster]

            foreach (Monster monster in monsters)
            {
                // 주소가 있기 때문에 수정이 안된다. 엘리먼트 자체는 수정 불가
               // monster = new Monster();
               monster.hp = 10; // 엘리먼트 내부 필드는 수정 가능
            }

        }

        static void Start()
        {
            //(1)
            int[] a = new int[5];
            int sum = 0;
            float avg = 0;

            a[0] = 5;
            a[1] = 8;
            a[2] = 12;
            a[3] = -3;
            a[4] = 7;

            sum = a[0] + a[1] + a[2] + a[3] + a[4];
            avg = sum / (float)5.0;

            Console.WriteLine($"총점 : {sum} , 평균 : {avg}");


            //(2)
            int[] b = { 15, 3, 9, 27, -5, 8 };

            Console.WriteLine(b.Max());
            Console.WriteLine(b.Min());

            
            foreach (int Max in b)
            {
                if (Max > 26)
                    Console.WriteLine($"{Max}");
                else
                    return;
            }

            foreach (int Min in b)
            {
                if (Min < 0 && Min < -8)
                    Console.WriteLine($"{Min}");
                else
                    return;
            }
            //(3)
            int[] nums = { 1, 0, 2, 2, 1, 0, 0, 2, 1, 1 };
            


        }
        

    }

    class _2차원배열
    {
        //데이터 타입[ , ] = new 타입 [행, 열 ]
        // map[행, 열 ] = 값;
        // 축약형
        // int[,] bord = { { 1,0,0,1} {0,0,0,0}{ 1,1,1,1} };

        public void Render()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                { 
                }
            }

        }
        //        static void Main()
        //        {
        //            // 1 1 1 1 1 1 1 1 1 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 0 0 0 0 0 0 0 0 1
        //            // 1 1 1 1 1 1 1 1 1 1

        //            /*
        //             -------------------------------------------------
        //            [ 1차원 배열로 10×10 맵을 표현한 경우 ]
        //            -------------------------------------------------
        //            Index:   0   1   2   3   4   5   6   7   8   9 ...
        //            Value:  [1] [1] [1] [1] [1] [1] [1] [1] [1] [1] ...

        //            (2, 5) 좌표 → index = 2*10 + 5 = 25  // 매번 계산 필요
        //             */

        //            /*
        //             -------------------------------------------------
        //            [ 2차원 배열로 10×10 맵을 표현한 경우 ]
        //            -------------------------------------------------
        //            Row 0: [1] [1] [1] [1] [1] [1] [1] [1] [1] [1]
        //            Row 1: [1] [0] [0] [0] [*] [1] [0] [0] [0] [1]
        //            Row 2: [1] [0] [0] [1] [0] [0] [1] [0] [0] [1]
        //            ...
        //            Row 9: [1] [0] [0] [0] [0] [0] [0] [0] [0] [1]

        //            (2, 5) 좌표 → map[2, 5]  // 직관적, 계산 불필요
        //             */

        //            // 데이터타입[,] = new 타입[행, 열]
        //            int[,] map = new int[10, 10];
        //            // map[행, 열] = 값;
        //            map[0, 0] = 1;
        //            map[0, 1] = 2;
        //            map[1, 2] = 3;
        //            map[2, 3] = 4;

        //            Render();

        //            int[,] test = new int[3, 4];

        //            int[][] jagged = new int[3][];
        //            jagged[0] = new int[3];      // 0행 길이 3
        //            jagged[1] = new int[5];      // 1행 길이 5(다름)
        //            jagged[1] = new int[4];      // 1행 길이 4(다름)

        //            //[ [][][] ]
        //            //[ [][][][][] ]
        //            //[ [][][][] ]
        //        }

        //        static public void Test()
        //        {
        //            foreach (int x in board)
        //            {
        //                Console.Write(x);
        //            }
        //        }

        //        static public void Render()
        //        {
        //            for (int x = 0; x < board.GetLength(0); x++)
        //            {
        //                for (int y = 0; y < board.GetLength(1); y++)
        //                {
        //                    if (board[x, y] == 1)
        //                        Console.ForegroundColor = ConsoleColor.Red;
        //                    else
        //                        Console.ForegroundColor = ConsoleColor.Green;
        //                    Console.Write('\u25cf');
        //                }
        //                Console.WriteLine();
        //            }
        //            Console.ResetColor();
        //        }
        //    }
        //}

        ////-10×10 맵을 2차원 배열로 정의하라.
        ////- 1은 벽, 0은 빈칸으로 간주하고, 벽은 '■', 빈칸은 '·' 문자로 출력하라.
        ////- 각 행은 줄바꿈으로 구분한다.
        //static public int[,] board = {
        //        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1,},
        //        { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
        // };
        //static void Main()
        //{
        //    int[,] map = new int[10, 10];

        //    for (int x = 0; x < board.GetLength(0); x++)
        //    {
        //        for (int y = 0; y < board.GetLength(1); y++)
        //        {
        //            if (board[x, y] == 1)
        //                Console.Write("■");
        //            else
        //                Console.Write("·");

        //        }
        //        Console.WriteLine();
        //    }
        //    //========================
        //    //문제 3) 전치(Transpose) 출력
        //    //========================
        //    //- 3×3 배열을 전치하여 출력하라.
        //    //- 전치란 a[r,c]를 aT[c,r]로 바꾸는 것이다.

        //    //int[,] a = new int[3, 3]
        //    //        {
        //    //            { 1, 2, 3 },
        //    //            { 4, 5, 6 },
        //    //            { 7, 8, 9 }
        //    //        };
        //    int[,] a = new int[3, 3]
        //            {   {1,2,3},
        //                 {4,5,6},
        //                { 7,8,9}
        //            };


        //    int[,] Transpose(int[,] input)
        //    {
        //        int rows = a.GetLength(0);
        //        int cols = a.GetLength(1);
        //        int[,] result = new int[cols, rows];

        //        for (int i = 0; i < rows; i++) // int 행 = 0 ;i < 행 ; 행++
        //        {
        //            for (int j = 0; j < cols; j++) // int 열 = 0; j < 열 ; 열++
        //            {
        //                result[j, i] = input[i, j];
        //                Console.WriteLine($"{result}");
        //            }
        //        }

        //        return result;
        //        
        //    }
            



        //}

    }

    class _리스트
    {
        //static void Main()
        //{
        //    // List - 필요할 때 자동으로 커지는 배열
        //    // 내부적으로는 배열, 클래스 내부에서 배열을 관리
        // [ 0 ][ 1 ][ 2 ][ 3 ]   // 꽉 찼음
        //            //   ↓
        //            // [ 0 ][ 1 ][ 2 ][ 3 ][ _ ][ _ ][ _ ][ _ ]   // 더 큰 배열로 교체

        //    List<int>numbers = new List<int>();
        //    List<string>Player=new List<string>();
        //    //제네릭 문법 < int > : 여기 안에 저장할 데이터의 타입을 지정
        //    //예) List<float> , List<string>, List<Player>등

        //    //인덱스를 통해 접근

        //    // numbers[0] = 1; <- 에러

        //    //  1. 데이터 추가
        //    numbers.Add(10); // numbers[0] <--10
        //    numbers.Add(20); // numbers[1] <--20
        //    numbers.Add(30); // numbers[2] <--30

        //    //  2. 전체 출력
        //    for(int i = 0; i<=3; i++)
        //    {
        //        numbers.Add(i * 10);
        //    }

        //    for (int i = 0; i < 6; i++)
        //    {
        //        Console.WriteLine($"index{i} : {numbers[i]}");  
        //    }
        /*
         1) 데이터 추가 
            number.Add(10); --> numbers[0] == 10
            number.Add(10); --> numbers[0] == 10
            number.Add(10); --> numbers[0] == 10
            number.Add(10); --> numbers[0] == 10

            number.Add(20); --> numbers[1] == 20
                                numbers[2] == 25
            number.Add(30); --> numbers[3] == 30

            numbers.Insert(2, 25); // 1번 인덱스 number[1]에 25 삽입
            numbers.Insert(5, 25); // 리스트 범위 초과시 에러
            
            [0] [1] [2] [3]     // 2번 자리에 999 삽입
            [0] [1] [ ] [2] [3] // 2, 3, 4를 한 칸씩 뒤로 이동 후 삽입

            삭제
            bool test = numbers.Remove(10);  // 지우는데 성공하면 참 반환
            bool test1 = numbers.Remove(444); // 지우는데 실패하면 거짓 반환

            numbers.RemoveAt(6);              // 1번 인덱스 삭제
            numbers.RemoveAt(6);              // 인덱스 초과시 에러
            삽입, 삭제에 시간이 오래 걸린다.
            0(n) - 선형시간
            numbers.Clear(); 요소 전체 삭제

             배열(Array)                리스트(List)  
             크기 고정                  크기 유동적
             접근 속도 빠름             사용 편리
             메모리 절약 가능           삽입 / 삭제 자유로움
             크기 변경 불가             중간 삽입/삭제 시 성능 저하
        
        ====> 결론 : 데이터 개수가 변하지 않는다면 배열, 개수가 변한다면 리스트 


         */
        //}
    }

    class 딕셔녀리
    {
        static void Main() 
        {
            /*
             딕셔너리는 헤시 테이블을 사용함
            // 고유 키값
            // ID가 1234 몬스터 찾아서 HP 깍아라

            // for문으로 진행시
            // O(n) -3초 엄청난 수의 몬스터를 찾는 것은 리스트로 쓰는 것은 비효율적.
            // [ 리스트 검색 ]
//          // [0] → [1] → [2] → ... → [N]   // 처음부터 끝까지 탐색 (O(N))
            
            // 딕셔녀리 Dictionary
            // key - Value
            // O(1) - 즉시 --> 상수시간
            // [ 딕셔너리 검색 ]
            //    ┌───────┐
            // ID:1234 → 몬스터 객체  // Key로 바로 찾음 (O(1))
            //    └───────┘

            key = 데이터의 이름표
            value = 데이터 ( 내용물 )
            Dictionary<key타입, Value타입> 변수명 = new Dictionary<key타입, Value타입>();
            예 : Dictionary<int, string> --> key는 int, Value는 string
            예 : Dictionary<int, Monster> --> key는 int, Value는 Monster 클래스

            List<Monster> monsters = new List<Monster>();
            monsters.Add(new Monster());

            */

            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            dic.Add(1, new Monster(1));
            //dic.Add(1,new Monster(2));

            bool test = dic.TryAdd(1, new Monster(1)); // add 시도하는데 만약 동일키가 있으면 flase 반환 종료

            dic[1234] = new Monster(1234); // 이전에 키값이 없었으면 키값을 새로 생성해서 넣어줌
            dic[1] = new Monster(2); // 이전에 키값이 있었으면 해당 키의 벨류를 교체

            Monster monster1 = dic[1];
            //Monster monster2 = dic[2]; // 해당하는 키가 없으면 에러 발생
            Monster moster2;
            bool success = dic.TryGetValue(1, out moster2);

            bool success2 = dic.Remove(1);
            // 키값을 넣어주면 해당하는 엘리먼트를 삭제한다.
            // 그리고 삭제에 성공하면 true, 벨류값을 반환
            // 삭제에 실패하면 false 반환

            dic.Clear(); // 전체 삭제시

            // 딕셔너리는 두가지 행동을 함
            // 첫번째 : key 값을 해시(Hash)화 해서 인덱스로 변환하고 그걸 저장 ( 여러가지 일)
            // 두번째 : 변환된 해시 값을 큰 하나의 통에 통째로 넣는게 아니라 잘게 쪼갠 통에 넣어줌

        } 

    }
}
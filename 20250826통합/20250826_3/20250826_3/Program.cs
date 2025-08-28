using System.Diagnostics;

namespace _20250826_3
{
    internal class Program
    {
        
        static void Test1( int n)
        {
            int sum = n;

            // 1
            // O(1)
        }

        static void Test2( int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum++;
            }

            // n +1
            // O(n)
        }
        static void Test3(int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                { sum++; }
            }

            // 시간복잡도 = n^2 + 1
            // O(n^2)
        }

        static void Test4(int n)
        {
                int sum = 0;

                for (int i = 0; i < n; i++)
                {
                    sum++;
                }

                for (int j = 0; j < 2 * n; j++)
                {
                    for (int k = 0; k < 2 * n; k++)
                    {
                        sum++;
                    }
                }

                sum -= 100;
                
                // 1 + n + ( 4n^2 ) ---> n^2
                // 시간복잡도 : O(n^2)

                // 1~100 : 73
                // 50 = up
                // 75 = down
                // 63 = 

                // 100 → 50 → 25 → 12 → 6 → 3 → 1 
        }
        
        
        
        static void Main(string[] args)
        {
            // 시간복잡도 = 어떠한 알고리즘이 실행되는데 걸리는 시간
            // 주요 로직의 반복 횟수를 중점으로 측정

            // Big_0 : 반복해서 몇번 연산되는지 "대충" 판단
            // 1단계 : 시간복잡도 구하기
            // 2단계 : 가장 오래걸리는 애만 남기기
            // 3단계 : 상수형은 탈락시킨다.(버린다) -- > 그림 예시) 무한으로 갈때

            // 업엔다운 게임이 대표적인 O(log n) 알고리즘 이다.
            Stopwatch sw = new Stopwatch();

            int sum = 0;

            for (int i = 0; i < 1_000_000; i++)
            {
                sum += 1;
            }

            sw. Stop();

            Console.WriteLine($" 총 걸린 시간 :{sw.Elapsed.TotalMilliseconds} ms");
        }

    }

    // 배열, 리스트, 연결리스트 , 스택, 큐 - 차이점
    /*
     선형자료구조 - 자료를 순차적으로 나열함.
        ^
        |
        
     비선형 자료구조 - 하나의 자료 뒤에 다수의 자료가 올 수 있음
                        트리, 그래프

    [1] [] [] [] [] [] [] -- 선형자료구조
    [1]
     ㄴ[2]
     ㄴ[3]
     ㄴ[4]
     ㄴ[5]

    // 게임 오브젝트
        ㄴ> 버튼
            ㄴ> 텍스트

        ㄴ> 버튼

    배열
    배열[3] 배열은 검색 속도가 아주 빠름 O(1):상수시간
    즉, 배열은 [인덱스를 통한 접근 속도]가 아주 빠르다
    처음 설정한 크기가 고정되어 변경이 불가함
    메모리상에 연속된 형태로 데이터가 저장됨
    장점 : 데이터 연속
    단점 : 추가 / 삭제 불가

    동적 배열
    List<int> arr = new List<int>();
    arr.Add(1);
    arr.Add(1);
    arr.Add(1);
    내부적으로 배열 기반으로 동작
    크기가 꽉 차면 새로운 배열을 만들고 기존 데이터를 복사하여 확장함
    확장시 보통 1.5배 ~ 2배 단위로 확장 (언어/ 라이브러리에 따라 다름)
    장점 : 크기 확장 자동 처리
    단점 : 중간 삽입 / 삭제 느림 O(n) : 선형시간

    연결리스트 ( Linked List )
    각 원소(Node)가 데이터 + 다음 노드 + 이전 노드( 포인터 )로 구성됨
    메모리상에 연속적으로 배치될 필요 없음 ( 화살표로 연결 )
    노드 라는게 있고, 해당 노드에는 값과 다음, 또는 이전의 노드의 주소가 있음
    장점 : 중간 삽입 / 삭제가 빠름 O(1) : 상수 시간
    단점 : 특정 위치 검색이 느림

    내일 할 일
     동적 배열 구현
     */
}

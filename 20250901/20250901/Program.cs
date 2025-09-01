namespace _20250901
{
    class Graph
    {
        // DFS = 깊이 우선 탐색 ( Depth first Search )

        // 어떤 버텍스부터 시작해서 인접한 버텍스들을 재귀적으로 방문
        // 방문한 정점은 다시 방문하지 않습니다.
        // 각 분기마다 가능한 가장 멀~리 있는 버텍스까지 탐색
        // 넓이 x = 가로 * 세로
        // DFS의 핵심 = 내가 했던 일을 내 다음에게 떠넘긴다
        // DFS의 역할 : 끊긴 길 찾기

        // BFS = 너비 우선 탐색 ( breadth first Search)

        // 기억을 한다 => Queue 를 통해서 값을 넣고 제일 오래 기다른 놈부터 꺼내서 씀
        // BFS는 경로를 탐색해서 정보를 기억하는 녀석이지, 최단거리를 찾는 알고리즘이 아니다.
        // BFS의 역할 :그래프 경로 참색과 정보 기록.


        int[,] adj = new int[6, 6] // 인접 행렬 방식
        {
             { 0,1,0,1,0,0},
             { 1,0,1,1,0,0},
             { 0,1,0,0,0,0},
             { 1,1,0,0,1,0},
             { 0,0,0,1,0,1},
             { 0,0,0,0,1,0}
        };

        bool[] visited = new bool[6]; // 1. now부터 방문 체크 bool 배열
        bool[] found = new bool[6];
        int[] parant = new int[6]; // parant[0] ==> 0번 정점의 부모가 누구야?
        int[] distance = new int[6]; // 시작지점부터 'distance[0]' 해당 정점까지 걸린 길이 몇개야?

        public void DFS(int now)
        {
            // 1. now 부터 방문 후 방문 체크
            Console.WriteLine($"방문 : {now}");
            visited[now] = true;

            // 2. now와 연결된 정점들을 하나씩 확인,
            //    아직 방문하지 않은 정점을 방문

            for (int next = 0; next < adj.GetLength(0); next++)
            {
                if (adj[now,next] == 0)
                    continue;

                if (visited[next] == true)
                    continue;

                DFS(next); // 재귀함수
            }
        }

        public void SearchAll() 
        {
            // 어떻게 해야 그래프를 전체 다 순회할 수 있을까?
            for (int now = 0; now < adj.GetLength(0); now++)
            {
                if(visited[now] == false)
                    DFS(now);
            }
        }

        public void BFS(int start)
        {
            // 방문 목록
            found = new bool[6];

            // 예약 목록
            Queue<int> queue = new Queue<int>();
            // 예약 목록에 예약하기
            queue.Enqueue(start);
            // 방문 처리하기
           found[start] = true; // ---> 찾았다
            parant[start] = start;
            distance[start] = 0;

            while (queue.Count > 0)
            {


                // 예약 목록에서 예약을 꺼내와서 
                int now = queue.Dequeue();
                Console.WriteLine($"방문 : { now}");

                // 아직 예약 안한애들 전부 예약하기
                for (int next = 0; next < 6; next++)
                {
                    // 연결이 안되어있으면 넘기고
                    if (adj[now, next] == 0)
                        continue;

                    // 연결이 되어있으면 이미 예약이 되어있는지 확인,
                    // 예약 됬으면 넘기고
                    if (found[next] == true)
                        continue;

                    // 예약하기

                    queue.Enqueue(next);

                    // 예약한 놈 찾은 놈으로 설정
                    found[next] = true;

                    // 찾은 놈의 부모는 now
                    parant[next] = now;

                    // 찾은 놈의 거리는 = 부모 + 1을 해주면 됨
                    distance[next] = distance[now ] + 1;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
           // graph.DFS(0);
            graph.SearchAll();
        
            graph.BFS(0);
        }
    }
    /*
     1. 얕은 복사와 깊은 복사에 대해 설명하라.

     2. (C#) is와 as 연산자에 대해 설명하라.

     3. dictionary 와 heshSet에 대해 설명하라.

     4. List와 LinkedList의 차이를 설명하라.

        (C#) boxing, unboxing 에 대해 설명하라

        클래스와 구조체의 차이점을 설명하라

        추상클래스, 인터페이스에 대해 설명하라.

        오버로딩과 오버라이딩의 차이에 대해 설명하라.

        Event와 delegate 의 차이가 무엇인가?

        람다식은 무엇인가?

        접근제한자는 어떤게 있고 각각을 설명하라

        가상 메서드란 무엇인가?

        Func, Action, delegate 의 차이를 설명하라

        인덱서란 무엇인가?

        박싱 언박싱이 무엇인가?

        가변배열과 고정배열의 차이

        프로퍼티가 무엇인지, private set에 대해 알고있는지

        스택 과 큐의 차이점

        자료구조중 구현할 수 있는걸 말해달라(구현 필수)

        부동소수점 float speed = 0.1f; 가 있다면 
i       f문에서 speed == 0.1f 이런 조건을 넣는 것은 틀린 것이다.
        그 이유를 설명하라

        객체 지향 언어란 무엇인가?

        몬스터라는 임의의 클래스를 구조체로 변경 했을 때 예상되는 문제점
        은 무엇이 있는가? 왜 그렇게 생각하는가?

        알고 있는 모든 캐스팅의 종류와 그 설명 (C++의 경우 여러개)

        부모 클래스와 자식클래스가 있다고 했을때 자식 클래스를 객체로
        생성시 어느 생성자가 먼저 호출이 되고, 그 이유가 무엇인가?

        제네릭 클래스는 무엇인가?

        static 키워드에 대해 설명하라

        const 키워드에 대해 설명하라

        enum 에 대해 설명하라.

        얕은 복사와 깊은 복사 에 대해 설명하라

        값타입에 대해 아는대로 설명하라

        참조타입에 대해 아는대로 설명하라

        리플렉션에 대해 아는대로 대답하라.

        어트리뷰터에 대해 아는대로 대답하라.

        절차지향 / 객체지향에 대해서 설명

        박싱 언박싱을 설명하고 이를 대체할수 있는 방법이 있는지 대답하라

        ref, out 키워드 설명하라

        기본 자료형(int, float)에 null 을 사용할 수 있는가?

        디자인패턴 아는거 있는지? (각각에 대한 기본적인 설명)

        DFS, BFS에 대해 아는대로 설명하라.

        자료구조중 아는대로 설명하고 특징정인 시간복잡도를 설명하라

        벡터의 내적과 외적을 게임에서 사용하는 경우
        GC 란 무엇인가?

        클래스와 인스턴스를 각각 설명해달라

        트리에 대해 아는대로 설명

        해시테이블은 무엇인가?

        힙 정렬은 어떤 방식인가?
     */
}

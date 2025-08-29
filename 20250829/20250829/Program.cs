namespace _20250829
{

    #region 스택 큐
    /*
     선형 자료 구조 - 배열, 리스트, 연결리스트, 스택, 큐
     비선형 자료 구조 -그래프, 트리, 딕셔너리, 해시셋

     스택 -LIFO(last in first out) = 후입선출
     
     큐 - FIFO(first in first out ) =  선입선출

     스택, 큐 : 고정되어 있는 사용방식을 자료구조로 만들어 둠
                프로그래머들 모여서 자료구조를 만들자 할 때 의사소통이 수월하게 하기위함.
     스택 (stack )
     원칙 :LIFO(Last In, First Out, 후입선출)
     삽입 (push) : 맨 뒤(Top)에만 가능
     삭제 (Pop)  : 맨 뒤(Top)에서만 가능
     즉 , 마지막에 넣은 것만 꺼낼 수 있음

     큐 ( Queue )
     원칙 : FIFO(First in, Firts Out, 선입선출)
     삽입 (enqueue) : 맨 뒤(Rear)에만 가능
     삭제 (dequeue) : 맨 앞(Front)에서만 가능
     즉, 먼저 들어간 것부터 꺼낼 수 있음

     */
    #endregion

    /*
     Graph - 개념적으로 현실 세계의 사물이나 추상적인 개념간의 연결 관계를 표현 한다.
     정점 - vertex , 노드
            > 데이터를 표현 ( 위치, 사람, 물건 )
     간선 - 엣지
            >정점들을 잇는 선 ( 관계, 경로 )

    고정되어 있는 자료형 구조가 없다

     */

    internal class Program
    {
        class Vertex
        {
            public List<Vertex> edges = new List<Vertex>();
        }


        static void Main(string[] args)
        {
            Stack<int>stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int number = stack.Pop(); // 맨 뒤에서 아예 하나를 뽑아옴
            int number2 = stack.Peek(); // 맨 뒤에서 하나를 엿보기
            int result = -1;
            bool test = stack.TryPop(out result);
            // Push - 마지막에 데이터 넣기
            // Pop - 마지막 데이터 뽑아냄
            // Peek - 마지막 데이터 엿보기
            
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            int number3 = q.Dequeue();      // 맨 앞에서 아예 하나를 뽑아옴
            int number4 = q.Peek();         // 맨 앞에서 하나를 엿보기 

                                            // Push - 마지막에 데이터 넣기
                                            // Enqueue - 첫번째 데이터 뽑아냄
                                            // Peek - 첫번째 데이터 엿보기 

            //* 연결리스트로 구현할 수 있다 ---> 스택, 큐
           //LinkedList<int> list = new LinkedList<int>();
           //list.AddLast(1);
           // list.AddLast(2);
           // list.AddLast(3);
           // list.AddLast(4);
           // list.AddLast(5);
           // list.Last();

            //-----------------------------------------------------------------
            // 그래프 그림 그대로. 인덱스 0 = 1번 원

            // # 1 그래프
            List<Vertex> Vertexs = new List<Vertex>();
            Vertexs.Add(new Vertex());
            Vertexs.Add(new Vertex());
            Vertexs.Add(new Vertex());
            Vertexs.Add(new Vertex());
            Vertexs.Add(new Vertex());

            Vertexs[0].edges.Add(Vertexs[1]);
            Vertexs[0].edges.Add(Vertexs[2]);

            Vertexs[1].edges.Add(Vertexs[2]);
            Vertexs[1].edges.Add(Vertexs[3]);

            Vertexs[2].edges.Add(Vertexs[0]);
            Vertexs[2].edges.Add(Vertexs[2]);
            Vertexs[2].edges.Add(Vertexs[3]);

            Vertexs[3].edges.Add(Vertexs[4]);

            List<int>[] adj = new List<int>[5]
            {
                    new List<int> { 1, 2 },
                    new List<int> { 2, 3 },
                    new List<int> { 0, 2, 3 },
                    new List<int> {4 },
                    new List<int> { },

            };


            // # 2 가중치 그래프 
            List<Edge>[] adj1 = new List<Edge>[4]
            {
                new List<Edge> { new Edge(1, 2), new Edge(2, 3) },
                new List<Edge> { new Edge(2, 7), new Edge(3, 26) },
                new List<Edge> { new Edge(0, 3), new Edge(3, 12) },
                new List<Edge> { new Edge(4, 9) },
            };

            //--------------------------------------------------------------------

            // 0 - 엣지가 연결되어 있지 않음. 1 - '두개의 정점(원)의' 엣지가 서로 연결되어 있음 
            // false, true로도 가능
            int[,] adj2 = new int[5, 5]
                {
                    {0,1,1,0,0 }, // 0 번점 표시
                    {1,0,1,1,0 }, // 1 번점 표시
                    {1,1,0,1,0 }, // 2 번점 표시
                    {0,1,1,0,1 }, // 3 번점 표시
                    {0,0,0,1,-1}, // 4 번점 표시

                };

            // 가중치 그래프로 표현. 양뱡항일 때 대각선으로 대칭되게 만들어진다.
            int[,] adj3 = new int[5, 5]
                {
                    { -1, 02, 03, -1, -1 }, // 0번점 표시
                    { 02, -1, 07, 26, -1 }, // 1번점 표시
                    { 03, 07, -1, 12, -1 }, // 2번점 표시
                    { -1, 26, 12, -1, 09 }, // 3번점 표시
                    { -1, -1, -1, 09, -1 },
                };
            //------------------------------------------------------
            int[,] gra = new int[6, 6]
                {
                    {-1, 7, -1, 3, -1,-1 }, // 0 번점 표시
                    {7, -1, 9, 12, -1, -1 }, // 1 번점 표시
                    {-1, 9, -1, -1, -1, -1 }, // 2 번점 표시
                    {3, 12, -1, -1, 23, -1 }, // 3 번점 표시
                    {-1, -1, -1, 23, -1, 34 }, // 4 번점 표시
                    {-1, -1, -1, -1, 34, -1 } // 5 번점 표시
                };
        }
    }

    internal class Edge
    {
        public int vertex;
        public int weight;

        public Edge(int v, int w)
        {
            vertex = v;
            weight = w;
        }
    }
}

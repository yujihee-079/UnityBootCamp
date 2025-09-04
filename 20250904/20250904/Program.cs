using _20250904;

namespace _20250904
{
    class Graph
    {
        int[,] adj = new int[8, 8]
        {
            { -1, 10, -1, 18, -1, -1, -1, -1 },     // 0번
            { 10, -1, 05, 06, -1, -1, -1, -1 },     // 1번
            { -1, 05, -1, -1, -1, -1, -1, -1 },     // 2번
            { 18, 06, -1, -1, 13, -1, -1, -1 },     // 3번
            { -1, -1, -1, 13, -1, 14, 08, -1 },     // 4번
            { -1, -1, -1, -1, 14, -1, -1, 17 },     // 5번
            { -1, -1, -1, -1, 08, -1, -1, 26 },     // 6번
            { -1, -1, -1, -1, -1, 17, 26, -1 }      // 7번

        };

        public void Dijkstra(int start)
        {
            bool[] visited = new bool[8];
            int[] distance = new int[8];
            int[] parent = new int[8];
            Array.Fill(distance,Int32.MaxValue);

            distance[start] = 0;
            parent[start] = 0;

            while (true)
            {
                // 제일 좋은 후보 찾기 ( 최단 거리 후보 )

                // 가장 유혁한 후보의 거리 번호를 저장
                int closest = Int32.MaxValue;
                int now = -1;

                // 모든 정점을 순회하면서 후보가 맞는지 체크
                // 각 정점을 순회하면서 애당초 얘가 후보가 맞는지 ( 연결이 되어 있는지 ) 확인
                for (int i = 0; i < 8; i++)
                {
                    // 이미 방문한 정점은 스킵
                    if (visited[i] == true)
                        continue;


                    // 아직 발견(예약)된 적이 없거나, 기존 후보보다 멀면 스킵
                    if (distance[i] == int.MaxValue || distance[i] >= closest)
                        continue;
                    
                    // 발견한 후보중 가장 좋은 후보를 찾음, 정보를 갱신
                      closest = distance[i];
                        now = i;
                    }
                    // 한번도
                    if (now == -1)
                    break;

                    // 제일 좋은 후보 방문
                    visited[now] = true;

                //   방문한 정점의 인접점을 확인하면서 최단 거리를 갱신해야함
                for (int next = 0; next < 8; next++)
                {
                    // 연결이 되어있지 않은 정점 스킵
                    if (adj[now, next] == -1)
                        continue;

                    if (visited[next] == true)
                        continue;

                    // 새로 조사된 인접 정점의 최단 거리 계산
                    int nextDist = distance[now] + adj[now, next];

                    // 위의 인접 정점의 최단 거리를 갱신
                    if (nextDist < distance[next])
                    {
                        distance[next] = nextDist;
                        parent[next] = next;    
                    }
                    //distance[next]
                    // 1 : 10
                    // 3 : 18 --> 16 ( 10 + 6 )
                    
                }
                }
            }
        }
    }

    internal class Program
    {
        /* 다익스트라(Dijkstra)
         
        BFS 단점
        가중치 접근에 대한 경로는 어렵다
        - 모든 경로의 이동이 동일한 조건일 때 즉, 가중치가 없는 그래프에서 사용 가능


         */



        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.Dijkstra(0);
        }
    }



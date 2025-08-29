namespace _20250828
{
    class Monster
    {
        public int Id;

        public Monster(int id)
        {
            this.Id = id;
        }

    }
    class Progaram
    {
        static void Main()
        {
            List<Monster> monster = new List<Monster>();

            Dictionary<int, List<Monster>> monsters = new Dictionary<int, List<Monster>>();
            monsters.Add(1, new List<Monster>());

            


            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "hi");

            HashSet<string> list = new HashSet<string>(); // 중복되는 데이터는 넣을 수 없다
            list.Add("a"); // 벨류가 즉  키 값
            list.Clear();
        }
        // 해시테이블 - > 실제로 자료형 있었음.
        /* 면접 예상 질문 답안
         1. 키값 입력 (해시셋의 경우 값이 곧 키)
         2. 키값을 GetHashCode() 함수로 해시와 (숫자화)
         3. 버킷이 모자르면 생성하는데 로드팩터 0.7을 유지하며, 그 값이 2의 거듭제곱보다 작다면 2의 거듭제곱 값으로 만들어줌
                                            (60개가 있다면 => 86개가 로드팩터이나 2의 거듭제곱 중 86보다 큰 128개로 만들어짐)
         4. 2.에서 만들어놓은 숫자화 값을 버킷의 개수로 나머지 연산함
         5. 나머지연산한 값이 버킷의 인덱스 변호함

         * 컬리전 상황 = 구조체, 동일한 값이 생김
         * : 컬리전이 생기면 같은 버킷에 여러 개의 요소가 연결된 형태로 들어가게 됨
         * 
                           딕셔너리                             |       해시셋
         저장 요소 |    key , value                             |       Value
         내부 구조 |    Entry { hashCode, Next, Key, Value |    |       Entry { hashCode, Next, Value }
         값 접근   |    dict[key]  --> valu 반환                |       set.Contains(Value  => Key)만 가능
         사용 목적 |    키로 값 빠르게 조회                     |       중복없는 리스트,  특정 원소 존재 여부
         단점      |    현재는 저장한 순으로 정렬되나           |       정렬 안됨
                        언제 바뀔지 모름
           
            struct Entry
            {
                public int hashCode;   // 키의 해시코드
                public int next;       // 같은 버킷 안에서 " 다음 엔트리 "가 있는 배열 인덱스
                public TKey key;
                public TValue value
            }

            private struct Entry
            {
                internal int hashCode;  // 요소의 해시
                internal int next;      // 충돌 체인의 다음 인덱스
                internal T value        // 저장된 값
            |
         */
    }
    //internal class Program
    //{
    //    class Node
    //    {
    //        public int Data;
    //        public Node Next;
    //        public Node Prev;
    //    }

    //    class MyLinkedList
    //    {
    //        public Node Head = null;
    //        public Node Tail = null;
    //        public int count;

    //        public Node AddLast(int data)
    //        {
    //            Node newNode = new Node();
    //            newNode.Data = data;

    //            // TODO : 구현
    //            if (Head == null)
    //            {
    //                Head = newNode;
    //            }

    //            if (Tail != null)
    //            {
    //                Tail.Next = newNode;
    //                newNode.Prev = Tail;
    //            }

    //            Tail = newNode;
    //            count ++;
    //            return newNode;
    //        }

    //        public void Remove(Node node)
    //        {
    //            // TODO : 구현
    //            // 삭제하려는 노드가 head노드인지 확인
    //            if (Head == node)
    //            {
    //                // 헤드 노드가 맞다면 헤드의 넥스트 즉 다음 노드에게 헤드를 넘겨준다
    //                Head = Head.Next;
    //            }

    //            // 지우려는 집이 Tail 노드인지 확인
    //            if (Tail == node)
    //            {
    //                //테일 노드가 맞다면  테일의 프리뷰 즉 이전 노드에게 테일을 넘겨준다
    //                Tail = Tail.Prev;   
    //            }

    //            // 지우려는 노드의 이전 집이 널인지 확인
    //            if (node.Prev != null)
    //            {
    //                //(지우려는 노드의 이전노드)의 다음노드를 지우려는 노드의 다음 노드로 변경
    //                (node.Prev).Next = node.Next;
    //            }

    //            // 지우려는 노드의 다음 누드가 널인지 확인
    //            if (node.Next != null)
    //            {
    //                //(지우려는 노드의 다음 노드)의 이전 노드를 지우려는 노드의 이전 노드로 변경
    //                (node.Next).Prev = node.Prev;
    //            }
    //            count--;
    //        }

    //    }
        //class My_List<T> // 복습
        //{
        //    public int count { get; set; }

        //    public int capacity { get { return _data.Length; } }

        //    T[] _data = new T[1];

        //    public T this[int index]
        //    {
        //        get
        //        {
        //            if (index >= count)
        //                throw new ArgumentOutOfRangeException(nameof(index));
        //            return _data[index];
        //        }
        //        set
        //        {
        //            if (index >= count)
        //                throw new ArgumentOutOfRangeException(nameof(index));
        //            _data[index] = value;
        //        }
        //    }

        //    public void Add(T item)
        //    {
        //        if (count >= capacity)
        //        {
        //            T[] newArr = new T[count * 2];

        //            for (int i = 0; i < count; i++)
        //            {
        //                newArr[i] = _data[i];
        //            }

        //            _data = newArr;

        //        }

        //        _data[count] = item;
        //        count++;
        //    }

        //    public void RemoveAt(int index)
        //    {
        //        for ( int i = index; i <count-1;  i++ )
        //        {
        //            _data[i] = _data[i+1];
        //        }

        //        count--;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    My_List<int> my_List = new My_List<int>();

        //    my_List.Add(1);
        //    my_List.Add(2);
        //    my_List.Add(3);
        //    my_List.Add(4);
        //    my_List.Add(5);

        //    my_List.RemoveAt(3);
        //    Console.WriteLine(my_List);
        //}

        //foreach ( int i in my_List)
        //{
        //    Console.WriteLine(i);
        //} 
        // GetEnumerator() 메서드가 없기 때문에 오류가 뜬다.

        //    class MyList<T>
        //{
        //    T[] items; // 아이템을 담는 배열
        //    int count; // 총 아이템 개수
        //    int size; // 배열의 크기
        //    public MyList()
        //    {
        //        size = 1; // 초기 리스트 크기를 1로 설정
        //        items = new T[size];
        //        count = 0;
        //    }
        //    public void Add(T item)
        //    {
        //        if (count == size)
        //        {
        //            Resize(); // 배열이 이미 꽉차있으면 크기를 늘림
        //        }
        //        items[count] = item; // 아이템을 추가
        //        count++; // 아이템 개수 1 증가
        //    }
        //    public void RemoveAt(int index)
        //    {
        //        if (index < 0 || index >= count)
        //        {
        //            throw new ArgumentOutOfRangeException(); // 유효하지 않은 인덱스(0미만 또는 총 아이템갯수 이상)에서 삭제 시 에러 발생
        //        }
        //        for (int i = index; i < count - 1; i++) // 인덱스부터 마지막 아이템을 1칸씩 앞으로 가져옴
        //        {
        //            items[i] = items[i + 1];
        //        }
        //        items[count - 1] = default!; // count-1 인덱스 아이템은 default 처리 (사용하지 않는값이기 때문에)
        //        count--; // 총 아이템 갯수 1개 감소
        //    }
        //    public T Get(int index)
        //    {
        //        if (index < 0 || index >= count)
        //        {
        //            throw new ArgumentOutOfRangeException(); // 유효하지 않은 인덱스 접근 시 에러 발생
        //        }
        //        return items[index]; // 인덱스의 아이템 반환
        //    }
        //    public int Count
        //    {
        //        get { return count; } // 총 아이템 갯수 반환
        //    }
        //    private void Resize()
        //    {
        //        size *= 2; // 배열 크기 2배로 증가
        //        T[] newList = new T[size];
        //        for (int i = 0; i < count; i++) // 새로운 배열로 기존 배열의 아이템을 옮김
        //        {
        //            newList[i] = items[i];
        //        }
        //        items = newList; // 기존 배열을 새 배열로 대체
        //    }
        //}

        //class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        MyList<int> list = new MyList<int>();
        //        list.Add(1);
        //        list.Add(2);
        //        list.Add(3);
        //        list.Add(4);
        //        list.Add(5);
        //        list.RemoveAt(2);
        //        Console.WriteLine("삭제 이후 인덱스 2의 아이템: " + list.Get(2)); // 4가 출력되어야 합니다.
        //    }
        //}

    //}
}

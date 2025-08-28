namespace _20250828
{
    internal class Program
    {
        class My_List<T>
        {
            public int count { get; set; }

            public int capacity { get { return _data.Length; } }

            T[] _data = new T[1];

            public T this[int index]
            {
                get
                {
                    if (index >= count)
                        throw new ArgumentOutOfRangeException(nameof(index));
                    return _data[index];
                }
                set
                {
                    if (index >= count)
                        throw new ArgumentOutOfRangeException(nameof(index));
                    _data[index] = value;
                }
            }

            public void Add(T item)
            {
                if (count >= capacity)
                {
                    T[] newArr = new T[count * 2];

                    for (int i = 0; i < count; i++)
                    {
                        newArr[i] = _data[i];
                    }

                    _data = newArr;

                }

                _data[count] = item;
                count++;
            }

            public void RemoveAt(int index)
            {
                for ( int i = index; i <count-1;  i++ )
                {
                    _data[i] = _data[i+1];
                }

                count--;
            }
        }

        static void Main(string[] args)
        {
            My_List<int> my_List = new My_List<int>();

            my_List.Add(1);
            my_List.Add(2);
            my_List.Add(3);
            my_List.Add(4);
            my_List.Add(5);

            my_List.RemoveAt(3);
            Console.WriteLine(my_List);
        }

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
        
    }
}

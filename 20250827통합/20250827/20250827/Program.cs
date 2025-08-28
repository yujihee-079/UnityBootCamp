namespace _20250827
{
    internal class Program
    {
        class My_List<T> // 제네릭 문법
        {
            // 내가 현재 몇개의 값을 쓰고 있는지 - > 필드
            // 저장될 변수 --> 필드
            // 배열이 꽉차면 배열을 2배 크기로 늘리기
            // 배열이 꽉 안차있으면 내가 사용한 배열 인덱스 마지막에 추가
            
            
            // 배열의 현재 크기 확인 -> if문
            // 이미 저장된 데이터 개수 = [배열 이름. Length] 와 배열의 총크기(capacity)를 비교한다.가 계획.
            
            public int count {  get; set; } // 내가 몇개 쓰고 있는지
            public int capacity { get { return _data.Length; } } // 현재 배열이 몇칸짜리 인지 

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
                //  방이 남았는지 확인 
              if ( count  >= capacity) // 비교
                {
                    // 배열을 2배 크기로 늘리기 = > 근데 늘리기가 되는가
                    // 그럼 어떻게 해야하는가>
                    // 어찌어찌 배열 늘렸음
                    // 기존 배열의 녀석들 어쩌지?
                    // 늘린 배열을 맨위의 필드로 만든 배열의 주소를 갈아치기 해주기
                    //int[] intArray = { }; nono
                    T[] newArr = new T[count * 2];
                    
                    //--------------------------------------
                    // 새로운 배열이 생겼으니까 이사하기.
                    for (int i = 0; i < count; i++)
                    {
                        newArr[i] = _data[i];
                    }

                    // 새로운 배열을 기존 배열에 연결
                    _data = newArr;
                }
                // 여기까지 왔다는 건 배열이 여유가 있다는것
                // Add가 해야 할 일을 하기
                // 그리고 아이템이 늘어났으니 또 해야할 일을 하기
                _data[count] = item;
                count++;
            }

            public void RemoveAt(int index)
            {
                //삭제를 해줘야 겠다
                //근데 굳이 삭제를 해야 하나>
                //그냥 한칸씩 당겨오면 되지 않나>
                //당겨왔으니까 해야할 일 하기

                for (int i = index; i < count - 1; i++)
                {
                    _data[i] = _data[i + 1];
                }

                count--;
            }
        }
        static void Main(string[] args)
        {
           List<int> list = new List<int>();
            list.Add(1); // 0번
            list.Add(2); // 1번

            int a = list[1];

            list.RemoveAt(1);

            My_List<int> list1 = new My_List<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);

            list1.RemoveAt(2);
        }
    }
}

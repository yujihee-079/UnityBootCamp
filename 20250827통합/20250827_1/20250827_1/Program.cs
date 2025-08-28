namespace _20250827_1
{
    //  배열 / 리스트 => 인덱스 접근 빠름 O(1), 하지만 중간 삽입/ 삭제 느림 O(n)
    // 연결 리스트 => 중간 삽입/ 삭제 빠름 O(1), 하지만 인덱스 접근 느림 O(n)
    class Node
    {
        public int Data;

        public Node Next;
        public Node Prev;
    }

    class MyLinkedList
    {
        public Node Head = null; // 첫 집 
        public Node Tail = null; // 끝 집

        public int count = 0;

        public Node AddLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if(Head == null) 
                Head =newNode;
            if (Tail != null)
            {
                Tail.Next = newNode;    // 마지막집의 다음 집
                newNode.Prev = Tail;    // newNode의 전 집은 마지막집
            }

            Tail = newNode;
            count ++;
            return newNode;
            // O(1) 상수시간
        }

        public void Remove(Node node)
        {
            // 삭제하려는 노드가 헤드 노드인지 확인
            if(Head == node)
            {   
                // 헤드 노드가 맞다면 헤드의 넥스트 즉 다음 번에게 헤드를 넘겨줌
                Head = Head.Next;
            }

            //  지우려는 집이 마지막집 인지 확인
            if (Tail == node)
            {
                Tail = Tail.Prev;
            }

            // 지우려는 노드의 이전 집이 널인지 확인
            if (node.Prev != null)
            {
                // (지우려는 노드의 이전노드)의 다음노드를 지우려는 노드의 다음 노드로 변경
                (node.Prev).Next= node.Next;
            }

            // 지우려는 노드의 다음 누드가 널인지 확인
            if (node.Next != null)
            {
                // (지우려는 노드의 다음노드)의 이전 노드를 지우려는 노드의 이전 노드로 변경
                (node.Next).Prev = node.Prev;
            }

            count --;
            // O(1) 상수시간
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 연결리스트는 노드를 리스트로 들고 있다
           LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            // 연결리스트 노드는 연결리스트의 하나의 요소이다.
            LinkedListNode<int> node = list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            list.Remove(node);

            MyLinkedList list1 = new MyLinkedList();
            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);
            list1.AddLast(4);
            list1.AddLast(5);

           // list1.Remove(node);
          
            
        }
    }
}

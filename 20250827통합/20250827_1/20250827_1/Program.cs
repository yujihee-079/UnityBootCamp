using System.Collections.Generic;

// 배열 / 리스트 → 인덱스 접근 빠름 (O(1)), 하지만 중간 삽입/삭제 느림 (O(n))
// 연결 리스트 → 중간 삽입/삭제 빠름 (O(1)), 하지만 인덱스 접근 느림 (O(n))

namespace LinkedList
{
    // 연결리스트의 하나의 요소
    class Node
    {
        public int Data;

        public Node Next;
        public Node Prev;
    }

    // 노드들이 모인 하나의 집합체 - 자료구조
    class MyLinkedList
    {
        // 현재 연결리스트의 첫번째 노드
        public Node Head = null;
        // 현재 연결리스트의 마지막 노드
        public Node Tail = null;
        // 현재 연결리스트가 갖고 있는 요소의 개수
        public int count = 0;

        // 현재 연결리스트의 마지막 에 노드 추가
        public Node AddLast(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (Head == null)
                Head = newNode;

            if (Tail != null)
            {
                Tail.Next = newNode;
                newNode.Prev = Tail;
            }

            Tail = newNode;
            count++;
            // O(1);
            return newNode;
        }

        // 해당 하는 노드 하나를 삭제
        public void Remove(Node node)
        {
            //                 
            //  [1] <-> [2] <-> [3] <-> [4] <-> [5]
            // Head                            Tail

            // 삭제하려는 노드가 헤드 노드인지 확인
            if (Head == node)
            {
                // 헤드 노드가 맞다면 헤드의 넥스트 즉 다음 번에게 헤드를 넘겨줌
                Head = Head.Next;
            }

            // 지우려는 노드이 마지막집 인지 확인
            if (Tail == node)
            {
                Tail = Tail.Prev;
            }

            // 지우려는 노드의 이전노드이 널인지 확인
            if (node.Prev != null)
            {
                // (지우려는 노드의 이전노드)의 다음노드을 지우려는 노드의 다음노드로 변경
                (node.Prev).Next = node.Next;
            }

            // 지우려는 노드의 다음노드가 널인지 확인
            if (node.Next != null)
            {
                // (지우려는 노드의 다음노드)의 이전노드를 지우려는 노드의 이전노드로 변경
                (node.Next).Prev = node.Prev;
            }

            count--;
            // O(1)
        }
    }

    class Program
    {
        static void Main()
        {
            // 연결리스트는 노드를 리스트로 들고있다.
            MyLinkedList list = new MyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            // 연결리스트 노드는 연결리스트의 하나의 요소이다.
            Node node = list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.Remove(node);
        }
    }
}
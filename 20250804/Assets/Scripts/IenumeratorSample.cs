using System.Collections;

using UnityEngine;

public class IenumeratorSample : MonoBehaviour
{
    class CustomCollection : IEnumerable
    {
        int[] numbers = {6, 7, 8, 9, 10};  
        // getenumerator�� ���� ��ȸ ������ �����͸� ienumerator ������ ��ü�� ��ȯ�մϴ�.
        public IEnumerator GetEnumerator()
        {
            for ( int i = 0; i<numbers.Length; i++) 
            {
                yield return numbers[i];
            }
           
          //  throw new System.NotImplementedException();
        }
    }


    int[] numbers = { 1, 2, 3, 4, 5 };


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // numbers ��� �迭�� ��ȸ�� �� �ִ� IEnumerator ������ �����ͷ� ��ȯ�մϴ�.
        IEnumerator enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Debug.Log(enumerator.Current); // ���� �۾��� �����ִ� �ڵ�.
        }

        CustomCollection collection = new CustomCollection(); // Ŀ���� �÷��� ����

        //foreach�� ��ȯ ������ �����͸� ���������� �۾��� �� ����ϴ� for�������� ���Ⱑ ���������ϴ�.
        foreach(int number in collection)
        {
            Debug.Log(number);
        }

        foreach( var number in GetMessage())
        {
            Debug.Log(number.ToString()); // .�� ��� ,��ǥ�� ���� ���� 2�μ��� ã�� �� ���ٰ� ���. string ���ڿ����� ����Ƽ �������� ��ȯ�� �� ���ٰ� ���.
        }

        /* yield�� c#���� �� ���� �ϳ� �� ���� �ѱ��, �޼ҵ尡 �Ͻ� ���� �Ǹ� �ļ� ������
         ���������� ��ȯ�ϰ� �մϴ�. ( �ݺ����� �۾�, �������� ������ ó���� ���˴ϴ�.)

         yield�� yield return, yield break�� ���˴ϴ�.

         yield return�� �޼Ҵٰ� ���� ��ȯ�ϸ鼭 �� �������� �޼ҵ� ������ �Ͻ� ���� ��ŵ�ϴ�.
         ȣ���ڰ� ���� ���� �䱸�� �� ���� ����մϴ�

        yield break �� �޼ҵ忡���� �ݺ��� �����ϴ� �ڵ��Դϴ�. ( ���� ����)

         yield return�� ����ϴ� �޼ҵ�� IEnUMerable �Ǵ� �̳ʸӷ����� �������̽��� �����ϰ� �˴ϴ�.
        �÷����� �ڵ����� ��ȸ�ϴ� foreach�� ���� ���˴ϴ�.

        ���� : ���� �ʿ�� �� ������ ����� �̷�� ���(�޸� ȿ���� ����, ū �����͸� ó���� �� ������ ũ��.)
        --> ��� �����͸� �����ϴ°� �ƴ� �ʿ��� �κи� ó���� �� �ְ� �Ǳ� ����

        IEnumerable : �ݺ� ������ �ݷ����� ��Ÿ���� �������̽��Դϴ�.
                      �� ����� ������ Ŭ������ �ݺ��� �� �ִ� ��ü�� �Ǹ�
                      foreach ���� �������� Ž���� ������ �� �ְ� �˴ϴ�.
                      �ش� �������̽��� �����ϱ� ���ؼ��� GetEnumerator() �޼ҵ带 �����ϰ�, ����ڰ� �����ؾ� �մϴ�.

        IEnumerator :  �ݺ��� �����ϴ� �������̽��Դϴ�.
                        �÷��ǿ��� �ϳ��� �׸���� ��ȯ�ϰ�, �� ���¸� �����ϴ� ������ �����մϴ�.
                        MoveNext()�� ���ؼ� ���� ���� ����
                        Current�� ���ؼ� ���� �� Ȯ��
                        Rest()�� ���ؼ� ���� ��� ó��


        */

       static IEnumerable GetMessage()
        {
            Debug.Log("�޼��� ����");
            //�߸� ��������, �ٽ� �ش� �޼ҵ�� ���ƿɴϴ�.
            yield return 1;
            Debug.Log("Ż�� �ߴٰ� ���ƿ� 1");
            yield return 2;
            Debug.Log("Ż�� �ߴٰ� ���ƿ� 2");
            yield break; // ��ȯ �۾� ����

            // -- Unreavhable Code -- ( ���� �Ұ�)--
            //Debug.Log("Ż�� �ߴٰ� ���ƿ� 3"); // ���� �Ұ��� ���Ƿ� �ۼ�.
           // yield return 3;
        }

    }

}

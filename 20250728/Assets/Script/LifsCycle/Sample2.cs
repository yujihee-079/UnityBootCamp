using UnityEngine;

public class Sample2 : MonoBehaviour
{
    public Sample1 sample1;

    private void Awake()
    {
        sample1 = GameObject.FindWithTag("s1").GetComponent<Sample1>();
        //1. GameObject.FindWithTag("�±��̸�")
        //--> ������ �ش� �±׸� ������ �ִ� ������Ʈ�� �˻��ϴ� ���
        //�� ����� ���� �޾ƿ��� �� ==> gameObject

        //2.gameObject.GetComponent<T>
        //���� ������Ʈ�� GetComponent<T>�� ���� T�� ������Ʈ�� ������
        //�ۼ����ָ� �ش� ���ӿ�����Ʈ�� ������Ʈ�� ������ �ִ� ���� �����ɴϴ�.
        //�� ����� ���� �޾ƿ��� �� ==> T

        Debug.Log(sample1.cc.message);
    }
}

using UnityEngine;

public class sample3 : MonoBehaviour
{
    //������Ʈ ĳ�̿� ���Ͽ� (Object cashing)

    // ĳ�� (Cashe)?
    // ���� ���Ǵ� �����ͳ� ���� �̸� �����صδ� �ӽ� ���

    //ĳ�� ��� �ǵ�
    //1. �ð� ������ : ���� �ֱٿ� ���� ���� �ٽ� ���� ���ɼ��� ����.
    //2. ���� ������ : �ֱٿ� ������ �ּҿ� ������ �ּ��� ������ ���� ���ɼ��� ����.

    Rigidbody rb;
    Vector3 pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //ĳ��(cashing)
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(pos * 5); //�����Ӹ��� ȣ��
    }
}

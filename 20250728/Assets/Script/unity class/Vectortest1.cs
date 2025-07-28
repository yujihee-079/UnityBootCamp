using UnityEngine;

public class Vectortest1 : MonoBehaviour
{
    //���� ������Ʈ�� Transform�� ���� Vector �� ���ϱ� ,���͸� �ʵ忡 �� ����.
    public Transform A_CUBE;
    public Transform B_CUBE;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� ť���� ��ġ�� ���ͷ� �����մϴ�.
        Vector3 posA = A_CUBE.position;
        Vector3 posB = B_CUBE.position;

        // �� ������ �� => ���� ����
        Vector3 btoa = posB - posA;
        Vector3 atob = posA - posB;

        //�Ÿ� ����
        //Distance�� ������ ����
        // a = (ax, ay, az)
        // b = (bx, by, bz)��� �� ��
        // �� ���� ������ �Ÿ���
        // �� �࿡ ���� ���� ������ �տ� ���� ��Ʈ ��
        // ��{(bx-ax)^2 + (by - ay)^2 + (bz -az)^2} 

        // ����Ƽ�� mathf Ŭ������ ������� �ٲٸ�?
        Vector3 dif = posB - posA;
        float distance = Mathf.Sqrt(dif.x * dif.x + dif.y * dif.y + dif.z *dif.z);
        Debug.Log(distance);

        distance = Vector3.Distance(posA, posB);
        Debug.Log(distance);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

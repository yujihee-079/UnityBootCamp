using UnityEngine;

public class LinerInter : MonoBehaviour
{
    // Vector3.lerp(start,end,t);
    // start -> end���� t�� ���� ���� �����մϴ�.
    // --> �ش� �������� ���� ���� õõ�� �̵��ϴ� �ڵ�
    // t�� ���� (0~1)�̰� float

    public Transform tarfet;
    public float speed = 1.0f;

    private Vector3 start_position;
    private float t = 0.0f;
    //t = ���� ����

    private void Start()
    {
        start_position = transform.position;
    }

    private void Update()
    {
        //������ ������ �ʾ��� ���� �̵��� �����ϰڽ��ϴ�.
        if (t < 1.0f) 
        {
            t += Time.deltaTime * speed;
            transform.position = Vector3.Lerp
                (start_position, tarfet.position, t);
        }
    }
}

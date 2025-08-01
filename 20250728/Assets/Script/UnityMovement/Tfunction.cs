using UnityEngine;

//�ﰢ �Լ�
//����Ƽ���� �������ִ� �ﰢ�Լ��� �ַ� ȸ��, ī�޶� ����, �, �����ӿ� ���� ǥ������ ���˴ϴ�.

//Ư¡ ) ������ �������� ����մϴ�. 1 ���� = �� 57��

public class Tfunction : MonoBehaviour
{
    // ���
    // sin(Radian) �־��� ������ y��ǥ (���� ���� ��ġ)
    // cos(Radian) �־��� ������ x��ǥ (���� ���� ��ġ)
    // tan(Radian) �־��� ������ ���� (y / x)

    // ���� ȸ��
    public void CircleRotate()
    {
        float angle = Time.time * 90.0f;
        float radian = angle * Mathf.Deg2Rad; // ���� �ش� ���� �����ָ� �������� ��ȯ���ϴ�.

        var x = Mathf.Cos(radian) * 5.0f;
        var y = Mathf.Sin(radian) * 5.0f;

        transform.position = new Vector3(x, y, 0);
    }

    public void ButterFly() 
    {
        float t = Time.time * 2;
        float x = Mathf.Cos(t) * 2;
        float y = Mathf.Sin(t * 2f) * 2 * 2;
        
        transform.position = new Vector3(x,y,0);
    }
    // Time.time : �������� ������ ���������� �ð� (( ��� �帣�� �ð�))
    // Time.deltaTime : �������� �����ϰ� �P���� �ð�  (�� ������ 1s)
    public void Wave()
    {
        var offset = Mathf.Sin(Time.time * 2.0f) * 0.5f;
        transform.position = pos + Vector3.up * offset;
    }

    Vector3 pos;// ��ǥ (��ġ)

    public void Start()
    {
        pos = transform.position;// ������ �� ������Ʈ�� ��ġ ����
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� Ŭ�� ���� ���� CircleRotate ȣ��
        if (Input.GetMouseButton(0))
        {
            CircleRotate();
        }

        if (Input.GetMouseButton(1))
        {
            Wave();
        }

        if (Input.GetMouseButton(2))
        {
            ButterFly();
        }
    }
}

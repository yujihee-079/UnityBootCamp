using UnityEngine;
// �߿� Ŭ���� Mathf
// ����Ƽ���� ���� �������� �����Ǵ� ��ƿ��Ƽ Ŭ����
// ���� ���߿��� ���� �� �ִ� ���� ���꿡 ���� ���� �޼ҵ�� ����� �����մϴ�.

// ex) ���� �޼ҵ� : static Ű����� ������ �ش� �޼ҵ�� Ŭ������ �޼ҵ��()
                  // ���� ����� �����մϴ�. Mathf.Abs(-5);

public class MathfSample : MonoBehaviour
{
    // �⺻������ ���Ǵ� �޼ҵ�
    float abs = -5f;
    float ceil = 4.1f;
    float floor = 4.6f;
    float round = 4.51f;
    float clamp;
    float clam01;
    float pow = 2;
    float sqrt = 4;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Mathf.Abs(abs));              //����(absolute number)
        Debug.Log(Mathf.Ceil(ceil));            //�ø�(�Ҽ��� ������� ���� �ø� ó���մϴ�.)
        Debug.Log(Mathf.Floor(floor));          //����(�Ҽ��� ������� ���� ���� ó���մϴ�.)
        Debug.Log(Mathf.Round(round));          //�ݿø�(5 ���ϸ� ������ 6 �̻��̸� �ø��ϴ�.)
        Debug.Log(Mathf.Clamp(7, 0, 4));        //���� ���޹��� �� = 7�� �ּ� =0 �ִ� =4 ��� ->4
                                                //��, �ּ�, �ִ� ������ ���� �Է��մϴ�. --> ���� ������ ������ ������ ����� �ȵ� ��
        Debug.Log(Mathf.Clamp01(5));            //���� ���� ���� �� =5 �ּ�=0 , �ִ� =1(�ڵ� ����) --> ����� �ּڰ� 0 �Ǵ� �ִ� 1�� ó��
                                                //�ۼ�Ʈ ������ ���� ó���� �� ���� ���Ǵ� �ڵ�( Ȯ�� )
                                                //�ּ� �ִ� ������ ���� 0�� 1�� �����˴ϴ�.
     // Clamp vs Clamp01
     // Clamp ==> ü��, ����, �ӵ� ���� �ɷ�â ���信���� ���� ����
     // Clamp01 ==> ����(�ۼ�Ʈ), ���� ��(1), ���� ��(���򿡼��� ����)

        Debug.Log("����" + Mathf.Pow(pow, 2)); // ��, ���� ��(����)�� ���޹޾Ƽ� �ش� ���� �ŵ� ������ ����մϴ�. pow ^2 xx
        Debug.Log("������" + Mathf.Pow(pow, 0.5f)); //Mathf.sqrt()�� ����ϴ� �ͺ��� ������ �ſ� ����
        Debug.Log("������ ������ ��� ���� ���� ���·� ����մϴ�." + Mathf.Pow(pow, -2f));  //2dml -2 wprhq => 1/4
        Debug.Log(Mathf.Sqrt(sqrt)); //���� ���� �޾� �ش� ���� �������� ����մϴ�.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

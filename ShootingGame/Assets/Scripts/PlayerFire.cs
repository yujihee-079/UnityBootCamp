using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [Header("�߻� ����")]
    [Tooltip("�Ѿ� ���� ����")]public GameObject bullerFactory;
    [Tooltip("�ѱ�")] public GameObject firePosition;

    private void Update()
    {
        //Getkeyxxx             : keycord�� ��ϵǾ� �ִ� Ű �Է�
        //GetButtonxxx          : Axes Ű�� ���� �Է�
        //GetMouseButtonxxx     : ���콺 Ŭ���� ���� ���� 0,1,2

        //Input Manager�� Fire1 Ű�� ���� �Է��� ������� ��� �߻縦 �����Ѵ�.
        if (Input.GetButtonDown("Fire1"))
        {
            // �Ѿ��� �Ѿ� ���� ���忡�� ����� �Ѿ��� �����Ѵ�.
            // �Ѿ��� ��ġ�� �ѱ� �������� �����ȴ�.
            // ������ ȸ���� ���� �ʴ´�.
            var bullet = Instantiate(bullerFactory, firePosition.transform.position,Quaternion.identity);
        }
    }

}

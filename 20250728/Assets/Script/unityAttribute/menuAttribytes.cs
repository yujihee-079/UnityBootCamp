using UnityEngine;
//Attritbute :{AddcomponentMenu("") ó�� Ŭ������ �Լ�, ���� �տ� �ٴ� []���� �Ӽ�(Attritbute)
//�����Ϳ� ���� Ȯ���̳� ����� ���� �� ���ۿ��� �����Ǵ� ��ɵ�
//��� ����: ����ڰ� �����͸� �� ����������, ���������� ����ϱ� ���ؼ�, �����Ϳ� ��ɹ��� �־���.


//1. AddComponentMenu("�׷��̸�/����̸�")
//Editor�� Component�� �޴��� �߰��ϴ� ���
//�׷��� ���� ��� �׷��� �����Ǹ�, �ƴ� ��쿡�� ��ɸ� �����˴ϴ�.
//���� ���� ���� ������ ���� ���� ������ ������ �ֽ��ϴ�.
//1. !, #, $, *�� ���� Ư�������� ��� �� ��
//2. ����
//3. �빮��
//4. �ҹ���
[AddComponentMenu("Sample/AddcomponentMenu")] // ��ǥ�� ������ ������� ����� ������. 
public class menuAttribytes : MonoBehaviour
{
    //[ContextMenuItem("������� ǥ���� �̸�", "�Լ��� �̸�")]
    //�޼����� ������� �޼������� ����� �����Ϳ��� ����� �� �ֽ��ϴ�.

    [ContextMenuItem("MeeageRest", "MessageRest")]
    public string message = "";
    public void MessageRest()
    {
        message = "";
    }
    [ContextMenu("��� �޼��� ȣ��)")]
    public void MenuAttributesMethod()
    {
        Debug.LogWarning("��� �޼���!");
    }

}

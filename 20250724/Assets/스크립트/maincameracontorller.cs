using UnityEngine;

public class maincameracontorller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //���� ������Ʈ Ÿ�� ���� player(����)
    // �� ���־� ��Ʃ������� �÷��̾� ��ǥ���� ���� ������ �ۺ��� �ʿ�� �ϴ�.
    public GameObject player;

    //ī�޶�� �÷��̾� ������ ���� offset(Vector3 : ����� )
    private Vector3 offset;

    void Start()
    {
        //ī�޶�� �÷��̾��� �Ÿ� ���̸� offset�� ������ �����Ѵ�.
        offset = transform.position - player.transform.position;
    }

 
    //update()���� ó���� �κ��� �� ó���� �Ŀ� ȣ��Ǵ� ��ġ
    //camera �۾����� ���� ���ȴ�. (������Ʈ ������ ������ ���)
    //������ ���� ����.
    private void LateUpdate()
    {
        
        //ī�޶��� ��ġ�� �÷��̾���� ���� �Ÿ��� �����Ѵ�. (offset)
        transform.position =player.transform.position + offset;

    }
}

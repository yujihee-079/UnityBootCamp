using UnityEngine;

public class boxrocaite : MonoBehaviour
{

    public Vector3 pos;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pos * Time.deltaTime);
        //Time.deltaTime�� ���� �����Ӻ��� ���� �����ӱ��� �ɸ� �ð�
        //update������ ���� ������ Ȱ��ȴ�.

        //transform.Rotate(Vector3 pos);
        //�ش� ��ǥ��ŭ ȸ���Ѵ�.

    }
}

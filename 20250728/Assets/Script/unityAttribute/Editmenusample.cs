using UnityEngine;

// ������ ��� ���¿��� update. onEnable. onDisable�� ����� ������ ������ �� �ֽ��ϴ�.
// �ﰢ���� ������ ���� �� ����ϰ� �����.
// play �� ������ �ʾƵ� ������ ������ update � ������ ��ɵ��� �����غ�.
[ ExecuteInEditMode]
public class Editmenusample : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Editor ������ �����غ��� �ڵ�
        if (!Application.isPlaying)
        {
            Vector3 pos = transform.position;
            pos.y = 0;
            transform.position = pos;

            Debug.Log("Editor Text...(�� ��ũ��Ʈ�� �� ������Ʈ�� y���� 0���� �����˴ϴ�.");
        }
    }
}

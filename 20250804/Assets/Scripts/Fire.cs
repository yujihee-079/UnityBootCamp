using UnityEngine;


// �� �ڵ�� �Ѿ˿� ���� �߻�(����) ��ɸ� ����մϴ�.
public class Fire : MonoBehaviour
{
    // �Ѿ� �߻縦 ���� Ǯ
    public Bulletpool pool;

    //�Ѿ� �߻� ����
    public Transform pos;

    //�Ѿ� �߻� �ӵ�
    public float speed = 2.0f;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = pool.GetBullet();

            bullet.transform.position = pos.position;

            bullet.transform .rotation = pos.rotation;
        }
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    //���� �ӵ� ���� speed, �� 5
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // ���� = ��
        Vector3 up = Vector3.up;

        //��ġ += ���� * �ӵ� * ��Ÿ Ÿ��(������Ʈ)
        transform.position += up * speed * Time.deltaTime;
    }
}

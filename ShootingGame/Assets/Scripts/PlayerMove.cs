using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    float h, v;

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0); // ����

        transform.position += dir * speed * Time.deltaTime; // ��ġ�� dir�Ÿ� * �ӵ� * �帣�� �ð�

        //transform.position = dir * speed * Time.deltaTime; 
        //����
        //�� ���� �� �����Ӹ��� dir * speed * Time.deltaTime��ŭ�� ��ġ�� �ٷ� �����ϱ� ������, ������Ʈ�� �׻� �� �������θ� �����̰�, ���� ��ġ�� ���õ˴ϴ�.

    }
}

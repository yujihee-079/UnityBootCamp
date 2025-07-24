using UnityEngine;

public class playercontorller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody>();
        //GetComponent<T>() : ���� ������Ʈ�� �پ��ִ� ������Ʈ�� �������� ����̴�.
        //T : type
        Debug.Log("������ �Ϸ�Ǿ����ϴ�!");

    }

    // Update is called once per frame
    void Update()
    {
        //speed += 1;
        //Debug.Log($"�ӵ��� 1 �����մϴ�. ���� �ӵ��� {speed}�Դϴ�.");

        //�����̵�
        float horizontal = Input.GetAxis("Horizontal");

        //�����̵�
        float vertical = Input.GetAxis ("Vertical");
        
        //�̵���ǥ (����) ����
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // add ���� ���ϴ�. force. �� -> ���� �̵�
        rb.AddForce(movement * speed);



    }

    private void OnTriggerEnter(Collider other)
    {
        //�浹ü�� ���� ������Ʈ�� �±װ� ITembox���?
        if (other.gameObject.CompareTag("Itembox"))
        {
            Debug.Log("������ ȹ��!");
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            speed -= 1;
            Debug.Log($"�ӵ��� 1 �����մϴ�. ���� �ӵ��� {speed}�Դϴ�.");

             

        }

    }

}

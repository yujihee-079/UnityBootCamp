using UnityEngine;

//1) �� ��ũ��Ʈ�� ����ϱ� ���ؼ��� Rigidbody ������Ʈ�� �䱸�˴ϴ�.
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    //[public]
    //�̵� �ӵ� (speed)
    public float speed;
    //���� �Ŀ� ��ġ (jp)
    public float jp;
    //�� ���̾� Ȯ��(���̾� ����ũ) (ground)
    public LayerMask ground;

    //[private]
    //������ٵ� (rb)
    private Rigidbody rb;
    //���� ���� �������� üũ (isGrounded)
    private bool isGrounded;


    void Start()
    {
        //������ �ٵ� ���� ����
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Ű �Է�
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");


        //���� ����
        Vector3 dir = new Vector3(x, 0, z);

        //�̵� �ӵ� ����
        Vector3 velocity = dir * speed;

        rb.linearVelocity = velocity;
        //������ �ٵ��� �Ӽ�
        //linearVelocity = ���� �ӵ�(��ü�� ���� �󿡼� �̵��ϴ� �ӵ�)
        //angularVelocity = �� �ӵ� (��ü�� ȸ���ϴ� �ӵ�)


        //���� ��� �߰�
        if(Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.AddForce(Vector3.up * jp, ForceMode.Impulse);
            //ForceMode.Impulse : �������� ��
            //ForceMode.Force : �������� ��
        }

    }

    private bool IsGrounded()
    {
        //�Ʒ� �������� 1��ŭ ���̸� ���� ���̾� üũ
        return Physics.Raycast(transform.position, Vector3.down, 1.0f, ground);
    }
}

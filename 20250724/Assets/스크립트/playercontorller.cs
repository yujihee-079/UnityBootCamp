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
        //GetComponent<T>() : 게임 오브젝트에 붙어있는 컴포넌트를 가져오는 기능이다.
        //T : type
        Debug.Log("설정이 완료되었습니다!");

    }

    // Update is called once per frame
    void Update()
    {
        //speed += 1;
        //Debug.Log($"속도가 1 증가합니다. 현재 속도는 {speed}입니다.");

        //수평이동
        float horizontal = Input.GetAxis("Horizontal");

        //수직이동
        float vertical = Input.GetAxis ("Vertical");
        
        //이동좌표 (벡터) 설정
        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // add 힘을 더하다. force. 힘 -> 물리 이동
        rb.AddForce(movement * speed);



    }

    private void OnTriggerEnter(Collider other)
    {
        //충돌체의 게임 오브젝트의 태그가 ITembox라면?
        if (other.gameObject.CompareTag("Itembox"))
        {
            Debug.Log("아이템 획득!");
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            speed -= 1;
            Debug.Log($"속도가 1 감소합니다. 현재 속도는 {speed}입니다.");

             

        }

    }

}

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

        Vector3 dir = new Vector3(h, v, 0); // 방향

        transform.position += dir * speed * Time.deltaTime; // 위치는 dir거리 * 속도 * 흐르는 시간

        //transform.position = dir * speed * Time.deltaTime; 
        //문제
        //이 줄은 매 프레임마다 dir * speed * Time.deltaTime만큼의 위치로 바로 설정하기 때문에, 오브젝트는 항상 그 방향으로만 움직이고, 이전 위치는 무시됩니다.

    }
}

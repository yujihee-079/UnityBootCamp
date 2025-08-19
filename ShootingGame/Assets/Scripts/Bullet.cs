using UnityEngine;

public class Bullet : MonoBehaviour
{
    //공개 속도 변수 speed, 값 5
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // 방향 = 위
        Vector3 up = Vector3.up;

        //위치 += 방향 * 속도 * 델타 타임(업데이트)
        transform.position += up * speed * Time.deltaTime;
    }
}

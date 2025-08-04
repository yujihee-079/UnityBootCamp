using System.Collections;
using UnityEngine;

// 총알에 대한 정보 , 총알 반납, 총알 이동

public class Bullet : MonoBehaviour
{
    public float speed =5.0f; // 총알 이동 속도

    public float life_time = 2.0f; // 총알 반납 시간

    public GameObject effect_prefab;  // 이펙트 프리팹
    

    private Bulletpool pool; // 풀

    private Coroutine life_coroutine;

    public void Setpool(Bulletpool pool) // 풀 초기화 풀 설정(풀에서 해당 값 호출)
    {
        this.pool = pool;
    }


    //활성화 단계
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulleReturn());

    }
    
    //비 활성화 단계
    private void OnDisable()   //if문 작성시 한 줄일 경우 중괄호 {} 생략 가능합니다.
    {
        if (life_coroutine != null)
            StopCoroutine(life_coroutine);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    IEnumerator BulleReturn()
    {
        yield return new WaitForSeconds(life_time);

        ReturnPool();
    }

    private void OnTriggerEnter(Collider other)
    {

        //부딪힌 대상이 Enemy 태그를 가지고 있는 오브젝트일 경우
        // 데미지를 입힙니다. 와 같은 데미지 관련 코드 작성

        // 이펙트 연출(파티클)
        ReturnPool();

        if(effect_prefab != null)
        {
            Instantiate(effect_prefab,transform.position,Quaternion.identity); // 이름. 포지션 방향
            

        }


    }

    //메소드의 명령이 한줄일 경우 , => 로 사용할 수 있습니다.
    void ReturnPool() => pool.Return(gameObject);


}

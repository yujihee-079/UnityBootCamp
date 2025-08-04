using System.Collections;
using UnityEngine;

public class CortineSample : MonoBehaviour
{
    //적용할 타겟
    public GameObject target;

    //변화 시간
    float duration = 5.0f;
    
    //바꾸고 싶은 색
    public Color color;

    // Coroutine coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Coroutine = StartCoroutine(ChangeColor());
        StopCoroutine(Coroutine);
        StoopCoroutine("ChangeColor"); 문자열
        StopAllCoroutines(); 모든 코루틴에 대한 중지 ( 현재 게임 오브젝트에서 실행 중인)
        */

        //타겟이 설정되어 있다면
        if (target != null)
        {
            StartCoroutine(ChangeColer());
            //startCoroutione(메소드명()) IEnumerator 형태의 메소드를 코루틴으로 시작합니다.
            //코드 작성과정에서 메소드가 결정되 안전함.
            //메소드 호출을 컴파일 과정에서 확인되기에 찾아 실행하는 시간이 문자열보다 적게 듭니다.

            //StartCoroutine("ChangeColor");
            // StartCoroutine(메소드명()); 문자열을 통해 매개변수가 없는 코루틴을 호출할 수 있습니다.
            /*
             * 내부적으로 ㅁ메소드의 이름을 문자열로 전달하고, 런타임에서 찾아서 실행하는 방식 ( 리플렉션 )
             * 타임 체크를 하지 ㅇ낳아서 잘못된 이름을 쓰면 런타임 오류 발생
             */
        }
        else
        {
            Debug.LogWarning("현재 타겟이 등록되지 않은 상태입니다.");
        }
    }

    IEnumerator ChangeColer() // 업데이트와 비교하는 코드. 무지성 vs 특정 시점 
    {
        //타겟으로부터 렌더러 컴포넌트에 대한 값을 얻어온다.
        var targetRenderer = target.GetComponent<Renderer>();

        // 조사한 타겟의 렌더러가 없을 경우
        if (targetRenderer == null)
        {
            Debug.LogWarning("현재 렌더러가 없는 상태입니다.");
            // 작업 중단
            yield break;
        }
        // 이 위치의 코드는 정상적으로 렌더러가 있을 경우에 실행되는 위치
        float time = 0.0f;

        // 타겟의 렌더러가 가진 머티리얼의 색깔을 사용
        var start = targetRenderer.material.color;
        var end = color;

        //반복 작업
        //코루틴 내에서 반복문을 설계하면, yield에 의해 빠져나갔다가 다시 돌아와서 반복문을 실행하게 됩니다.

        while (time < duration) //변화 시간만큼 작업
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time,duration) / duration;

            //Mathf.PingPong(a,b)
            //주어진 값을 a와 b 사이에서 반복되는 값을 생성합니다. (기ㅣ본적인 왕복운동)
            // 약 0~ 1 사이의 변화 값이 계산됩니다.
            // 정규화 작업을 진행한 이유 : color는 0부터 1까지의 값

            targetRenderer.material.color = Color.Lerp(start, end, value);  // Lerp는 A부터 b지점 까지 간격을 부드럽게 이동하는 코드
            // 즉 색상에 대한 부드러운 변경

            yield return new WaitForSeconds(1.0f); // null 하면 개빠르게 1f로 바뀜.
            // 만약 Time = 0.0f;로 초기화를 해주면 무한 반복됨. 효율이 좋은 편은 아님.

            Debug.Log("한 프레임이 끝났어요.");
        }
    }
    /* 코루틴 정지 기능
     * StopCoroutine(코루틴 객체);
     */

   

    
}

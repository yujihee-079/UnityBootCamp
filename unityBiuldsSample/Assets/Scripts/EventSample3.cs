using UnityEngine;
using UnityEngine.Events;
//unityEngine.Events 네임스페이스 연결이 필수입니다.

//c#의 Enent와의 차이점
//1.인스펙터에서 확인이 가능하다.
//2.추가 기능을 += , -= 으로 하지 않고 add_listener와 RevoveLister로 진행합니다.

/*
                        unityaction     vs      unityevent
    타입                 delegate                class
    기능                 함수참조                에디터에서 핸들러 직접 등록 가능
    구독                 + , -                   AddListener(). RemoveSistener()
    사용할 상황     스크립트 코드 내 정리        인스펙터용 이벤트 시스템
    속도                 빠름                    느림 ( @연결 정보에 대한 파싱 후 런타임 실행 방식)
    메모리               적음                    많음
    GC 발생 여부         낮음                    높음
    편의성          자체 설계 해야 함            바로 사용 가능, 쉽고 편함. 

UnityAction은 UnityEvent를 사용하는 코드를 설계할 때 효과적입니다.
일반 delegate는 UnityActon<T>와 같이 타입에 대한 설정이 따로 안되어있어 따로 만들어서 사용해야 합니다.

사용할 수 있는 선택지
1. c#의 Delegate
2. Unity의 UnityAction
3. c@의 Func<T>, Action<T>

이 다양한 delegate들을 
언제 어떤걸 사용해야 하는가..?

고성능을 원한다 --> c#delegate
콜백                Action, UnityAction
unityEvent와의 ---> unityAction
인스펙터 연결    
이벤트 시그니처 --> delegate, Func(Return), Action
필요;             (유연하게 설계)

이벤트 시그니처:
호출되는지에 정의한 함수의 형태
C#의 EventHandler의 선언
ew)delegate void EventHandler(object sender, EventArgs e );

시그니처
1. 반환타입
2. 매개변수
 */
public class EventSample3 : MonoBehaviour
{
    public UnityEvent ONKBunttonEnter;
    public UnityAction OnAction;

    private void Start()

    {
        //ONKBunttonEnter += sample ( @ 오류)
        ONKBunttonEnter.AddListener(Sample);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ONKBunttonEnter?.Invoke();
        }

    }

    private void Sample()
    {
        Debug.Log("<color=cyan>Sample 실행</color>");
    }
}

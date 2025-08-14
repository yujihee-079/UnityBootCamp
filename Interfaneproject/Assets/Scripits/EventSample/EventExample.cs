using System;
using UnityEngine;
// C# event 526 page
// event : 특정 상황이 발생했을 때 알림을 보내는 메커니즘
// 1. 플레이어가 죽었을 때 알림 전달 -> 메소드 호출

//                        Action vs event Action?
//                  Action           vs            event Action
// 외부호출             O                               x
// 외부 대입            O                               x
// 구독 기능            O                               O
// 구독 취소            O                               O
// 주 용도        내부로직, 콜백                   이벤트 알림


public class EventExample : MonoBehaviour
{
   

    public Action onDeath;
    public event Action onStart;

    private void Start()
    {
        //액션은 +=를 통해 함수(메소드)를 액션에 등록할 수 있습니다.  [ 구독 ]
        //액션은 -=를 통해 함수(메소드)를 액션에서 제거할 수 있습니다.  [ 해제 ]
        //액션의 기능을 호출하면 등록되어있는 함수가 순차적으로 호출됩니다.
        onStart += Ready;

        onStart += Fight;

        onDeath += Damaged;

        onDeath += Dead;

        onStart?.Invoke(); // onStart에 등록된 기능을 수행하는 코드 Invoke(); 
        onDeath?.Invoke();
        // onStart();   onDeath();   -> 함수처럼 자기자신을 호출하는 것이 가능
        // 둘의 차이? 없음. 문법 스타일 차이
        // ?.invoke 방식이면 null 체크 가능. 외부에서의 호출, 안전성 요구 시 추천
        // 함수 형태면 따로 설계, 내부 코드이거나 단순 호출일 경우 해당 방식 추천
        //if( onStart != null)을 추가하면 위의 invoke와 동일하게 기능
    }

    private void Fight()
    {
        Debug.Log("<color=yellow><b> Fight!!</b></color>");
    }

    private void Ready()
    {
        Debug.Log("<color=cyan><b> Ready?</b></color>");
    }

    private void Dead()
    {
        Debug.Log("<color=red><b> A Hero is fallen.</b></color>");
    }

    private void Damaged()
    {
        Debug.Log("<color=blue><b> Critcal Damage!</b></color>");
    }
}

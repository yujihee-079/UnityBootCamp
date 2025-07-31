using UnityEngine;
using UnityEngine.InputSystem;

//player Input가 존재해야 사용

//[RequireComponent(typeof(T))]는 이 스크립트를 컴포넌트로
//사용할 경우 해당 오브젝트는 반드시 T를 가지고 있어야 합니다.
//없는 경우라면 자동으로 등록해주고, 이 코드가 존재하는 한
//에디터에서 게임 오브젝트는 해당 컴포넌트를 제거할 수 없습니다.
/*
월드 좌표계 (World space)
씬 전체를 기준으로 사용하는 절대 좌표 = > 예측하지 못한 방향으로 움직이는 것을 막아준다.

(0,0,0)은 씬의 중심점

 * x : 좌 우
 * Y : 위 아래
 * z : 앞 뒤
 * 방향 고정
 * 특징 모든 게임 오브젝트가 공유
 * 하는 기준점과 축을 가짐.
 * 씬 내에서 어디서든 같은 위치와 
 * 방향을 가지게 됩니다.
 * (0,0,1) 앞으로 이동
 * 
 * 로컬 좌표계 (Local Space)
 * 특정 오브젝트 기준의 좌표
 * 오브젝트의 위치, 회전, 크기를 기준으로 좌표라 설정
 * 오브젝트의 방향에 따라 움직이게 됨.

*/

[RequireComponent(typeof(PlayerInput))]
public class InputSystemExample : MonoBehaviour
{
    //현재 Action Map : Sample
    //     Action     : move
    //     Type       : Value
    //     Compos     : Vector2
    //     Binding    : 2D Vector(WASD)

    //send message로 사용되는 경우
    //특정 키가 들어오면 , 특정 함수를 호출합니다.
    //함수 명은 On + Actions name, 현재 만든 Actions의 이름 Move라면
    //함수명은 OnMove가 됩니다.

    private Vector2 moveInputValue;
    private float speed = 3.0f;
    void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(moveInputValue.x,0,moveInputValue.y); // 좌우 x축 상하 z축
         transform.Translate(move *  speed *Time.deltaTime); // 월드 좌표계로 설정하려면 space.World를 적는다.
    }
}

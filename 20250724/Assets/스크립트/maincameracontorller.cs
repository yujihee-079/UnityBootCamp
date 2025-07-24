using UnityEngine;

public class maincameracontorller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //게임 오브젝트 타입 변수 player(공개)
    // 이 비주얼 스튜디오에선 플레이어 좌표값이 없기 때문에 퍼블릭이 필요로 하다.
    public GameObject player;

    //카메라와 플레이어 사이의 변수 offset(Vector3 : 비공개 )
    private Vector3 offset;

    void Start()
    {
        //카메라와 플레이어의 거리 차이를 offset의 값으로 설정한다.
        offset = transform.position - player.transform.position;
    }

 
    //update()에서 처리할 부분을 다 처리한 후에 호출되는 위치
    //camera 작업에서 많이 사용된다. (오브젝트 추적이 목적인 경우)
    //렌더링 이후 시작.
    private void LateUpdate()
    {
        
        //카메라의 위치는 플레이어와의 일정 거리를 유지한다. (offset)
        transform.position =player.transform.position + offset;

    }
}

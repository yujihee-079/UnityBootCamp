using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [Header("발사 설정")]
    [Tooltip("총알 생산 공장")]public GameObject bullerFactory;
    [Tooltip("총구")] public GameObject firePosition;

    private void Update()
    {
        //Getkeyxxx             : keycord에 등록되어 있는 키 입력
        //GetButtonxxx          : Axes 키에 대한 입력
        //GetMouseButtonxxx     : 마우스 클릭에 대한 설정 0,1,2

        //Input Manager의 Fire1 키에 대한 입력이 진행됐을 경우 발사를 진행한다.
        if (Input.GetButtonDown("Fire1"))
        {
            // 총알은 총알 생산 공장에서 등록한 총알을 생성한다.
            // 총알의 위치는 총구 지점으로 설정된다.
            // 별도의 회전을 넣지 않는다.
            var bullet = Instantiate(bullerFactory, firePosition.transform.position,Quaternion.identity);
        }
    }

}

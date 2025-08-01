using UnityEngine;
// Raycast : 시작 위치에서 특정 방향으로 가상의 광선을 쐇을 때
// 부딪히는 오브젝트가 있는지를 판단합니다.
// 1) 특정 오브젝트를 충돌 범위에서 제외하는 작업 가능
// 2) 특정 오브젝트에 대한 충돌 판정을 확인하는 용도

public class RayCastSample : MonoBehaviour
{
    RaycastHit hit; //충돌 감지용 변수

    // ref : 변수를 참조로 전달, 변수가 메소드 안에서 변경 될 수 있음을 알리는 용도.
    // out : 참조로 전달되는 것, 변수 전달 전에 변수에 대한 초기화를 진행할 필요가 없음.

    // physics,Raycast ( Vector3 origin, Vector3 diretion, out RayCastHit hitInfo,
    // float maxDistance, int layerMask);

    // origin 방향에서 dirction 방향으로 maxDistance 길이의 광선을 발사합니다. // 값을 정하지 않으면 확인 할 수 없다.

    // hitinfo는 충돌체에 대한 정보를 의미합니다.

    const float length = 20.0f; // 길이 변경 5f --> 20f

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 한 번에 여러 개의 레이캐스트 충돌 처리

        // 선 그리기
        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
        // 레이어 마스크 설정하기
        int ignorelayer = LayerMask.NameToLayer("Red");
        int layerMask = ~(1 << ignorelayer);
        // 충돌체 설정( 묶음 )
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, length, layerMask);
        //RaycastAll : 한 방향으로 쏜 레이가 충돌한 충돌체를 배열로 return

        for ( int i = 0; i < hits.Length; i++ ) // hits의 길이 (개수)만큼 반복을 진행합니다.
        {
            Debug.Log(hits[i].collider.name + "를 hit했습니다.");
            hits[i].collider.gameObject.SetActive(false);
            // hits 배열의 i번째 값의 충돌체가 가진 게임 오브젝트를 비활성화 합니다.
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        // 오브젝트의 위치에서 정면으로 Length만큼의 길이에 해당하는 디버깅 광선을 쏘는 코드
        // 주로 레이캐스트 작업에서 레이가 안보이기 때문에 보여주는 용도로 사용합니다.


        Debug.DrawRay(transform.position, transform.forward * length, Color.red); // 현재 카메라에 보이는 길이
        

        // 1. 충돌 시키고 싶지 않은 레이어에 대한 변수 설정

        int ignorelayer = LayerMask.NameToLayer("Red"); // 충돌 시키고 싶지 않은 레이어

        // 2. ~(1 << LayerMask.NameToLayer("레이어 이름")) 해당 레이어 이외의 값

        /*ex) 만약에 Red레이어랑 Blue 레이어를 둘 다 제외하고 싶은 경우
         * int ignoreLayers = (1<<LayerMask.NameToLayer("Red")) | (1<<Layermask.NameToLayer("Blue"));
         * int layermasks = ~igmoreLayers;
         */

        int layerMask = ~(1 << ignorelayer); // 비트 반전


        //왼쪽 버튼을 눌렀을 경우 레이 발사
        //  if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask)) // Max까지의 길이
            {
                Debug.Log("히히히 발싸");
                Debug.Log(hit.collider.name);
                hit.collider.gameObject.SetActive(false);

                //레이어마스크느 비트 마스크이며, 각 비트는 하나의 레이어를 의미합니다.
                // 1 << n은 n번째 레이어만 포함하는 마스크를 의미합니다.
                // ~에 의해 작성된 ~(1<<n)은 해당 레이어를 제외한 모든 레이어를 의미합니다.
            }
        }
        //
    }
}

using UnityEngine;

// 에디터 모드 상태에서 update. onEnable. onDisable의 기능을 실행을 진행할 수 있습니다.
// 즉각적인 실행을 원할 때 빈번하게 실행됨.
// play 를 누르지 않아도 에디터 내에서 update 등에 설계한 기능들을 실행해봄.
[ ExecuteInEditMode]
public class Editmenusample : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Editor 에서만 실행해보는 코드
        if (!Application.isPlaying)
        {
            Vector3 pos = transform.position;
            pos.y = 0;
            transform.position = pos;

            Debug.Log("Editor Text...(이 스크립트를 낀 오브젝트는 y축이 0으로 고정됩니다.");
        }
    }
}

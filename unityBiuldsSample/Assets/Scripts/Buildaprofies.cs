using UnityEngine;


public class Buildaprofies : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
#if CUSTOM_DEBUG_MODE
        Debug.Log("디버그 모드에서 실행 중인 기능입니다!");
#elif CUSTOM_RELEASE_MODE
        Debug.Log("릴리스 모드에서 실행 중인 기능입니다!");
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

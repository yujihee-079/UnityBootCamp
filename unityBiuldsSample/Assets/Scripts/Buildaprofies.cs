using UnityEngine;


public class Buildaprofies : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
#if CUSTOM_DEBUG_MODE
        Debug.Log("����� ��忡�� ���� ���� ����Դϴ�!");
#elif CUSTOM_RELEASE_MODE
        Debug.Log("������ ��忡�� ���� ���� ����Դϴ�!");
#endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class SampleSpawner : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 해당 오브젝트가 없을 때 오브젝트를 생성하고 , 컴포넌트를 부여하기 

        GameObject sample = GameObject.Find("Sample");

        if (sample == null)
        {
            GameObject go = new GameObject("Sample");
            go.AddComponent<Sample>();
        }
        else
        {
            Debug.Log("이미 존재합니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class SampleSpawner : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �ش� ������Ʈ�� ���� �� ������Ʈ�� �����ϰ� , ������Ʈ�� �ο��ϱ� 

        GameObject sample = GameObject.Find("Sample");

        if (sample == null)
        {
            GameObject go = new GameObject("Sample");
            go.AddComponent<Sample>();
        }
        else
        {
            Debug.Log("�̹� �����մϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

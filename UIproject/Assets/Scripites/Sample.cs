using UnityEngine;

public class Sample : MonoBehaviour
{
    string items = "���� ����, �Ķ� ����, ��Ȳ ����";

    string[] item_table;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        item_table = items.Split(',');
        // ���� ��ü���� , �� �������� ������ ������ ���/ ��ȣ���� ��������

        foreach (string item in item_table)
        {
            Debug.Log(item);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

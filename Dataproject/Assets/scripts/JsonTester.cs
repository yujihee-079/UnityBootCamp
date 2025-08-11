using UnityEngine;
using System.Collections;
using System;

public class JsonTester : MonoBehaviour
{
    /*
     * ����Ƽ���� ��ü�� �ʵ带 ���̽����� ��ȯ�ϱ� ���ؼ���
     * ���������� �޸𸮿��� �����͸� �а� ���� �۾��� �����ؾ� ��.
     * ���� [Serializable] �Ӽ��� �߰��� �ش� ������ ���� ����ȭ�� ó���� �� �ʿ䰡 �ֽ��ϴ�.
     * 
     * ����ȭ�� �����͸� �����ϰų� �����ϱ� ���� �������� �������� ���·� �������ִ� �۾��� �ǹ��մϴ�.
     */
    [Serializable]
    public class Data
    {
        public int hp;
        public int atk;
        public int def;
        public string[] items;
        public position position;
        public string quest;
        public bool isDead;
    }

    [Serializable]
    public class position
    {
        public float x;
        public float y;
    }

    public Data my_data;

    public void Start()
    {
        var jsonText = Resources.Load<TextAsset>("data01");

        if (jsonText == null)
        {
            Debug.Log("�ش� JSON ������ ���ҽ� �������� ã�� ���߽��ϴ�!");
            return;
        }

        //json ���ڿ��� ��ü�� ���·� ��ȯ�մϴ�.
        my_data = JsonUtility.FromJson<Data>(jsonText.text);

        Debug.Log(my_data.hp);
        Debug.Log(my_data.quest);
        Debug.Log(my_data.atk);
        Debug.Log(my_data.def);
        Debug.Log(my_data.position.x);
        Debug.Log(my_data.position.y);

        foreach( var item in my_data.items)
        {
            Debug.Log(item);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

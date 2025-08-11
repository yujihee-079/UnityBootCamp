using System;
using System.IO;
using UnityEngine;

public class JsonMaker : MonoBehaviour
{
    [Serializable]
    public class QuestData
    {
        public string quest_name;
        public string reward;
        public string description;
           
    }

    [Serializable]
    public class QuestList
    {
        public QuestData[] quests;
    }

    public void Start()
    {
        QuestList list = new QuestList()
        {
            quests = new QuestData[]
            {

                new QuestData()

                { quest_name = "������ ���̴�", reward = "extp + 100", description = "�����̶� �ϸ� ���̶� ���� "
                },

                new QuestData()
                { quest_name = "�߰��� �ض�", reward = "exp + 150", description = "�߰��̶� �ϴ°� ���� ."
                },


                new QuestData()
                { quest_name = "�Ҳ��� ������ �ض�." , reward = "exp + 500" , description = "�׳� �� �϶�� ���ݾ�.."
                }

            }
        };
        /*
         * 2) JsonUtility.TOJson(Objext, pretty_print);�� ���� c#�� ��ü�� json���� �������ִ� ����ȭ ����� ���� �Լ�
          Tojson(��ü)�� �ش� ��ü�� Json ���ڿ��� �������ִ� �ڵ�
          true�� �߰��� ���, �鿩����� �ٹٲ��� ���Ե� ������ Json ���Ϸ� ������ �ݴϴ�.
          false�� ���ų� �����ϴ� ����� ���� �� �ٷ� ����� Json ���Ϸ� �����˴ϴ�.
          
          *3) ���� ��ο� ���� �ۼ��� �����մϴ�.
          Path.Combine(string path1, string path2);
          �� ����� ���ڿ��� �ϳ��� ��η� ����� �ִ� ����� ������ �ֽ��ϴ�.
          ������ġ / ���ϸ����� ���� ���˴ϴ�.
         
          Application.persistentDataPath : ����Ƽ�� �� �÷������� �����ϴ� ���� ���� ������ ���� ���

        * 4) �ش� ��ο� ������ �ۼ�
        ������ ���� ������ C# 723 page : System.IO ���� �����̽�
                              725 page : path Ŭ������ ���� ���� �̸�, Ȯ����, ���� ���� ��� ���
                              733 page : Json �����Ϳ� ���� ����
         
         */
        string json = JsonUtility.ToJson(list, true);

        Debug.Log($"�� ���� ���� ��ġ : {Application.persistentDataPath}");
        string path = Path.Combine(Application.persistentDataPath, "quests.json");

        File.WriteAllText(path, json);

        Debug.Log("JSON ���� ���� �Ϸ�");

        //============= ���� �ε� ================
        //1) �ش� ��ο� ������ �����ϴ��� �Ǵ��ϼ���.

        if (File.Exists(path))
        {
            //���� �ؽ�Ʈ�� ���� �о ������ �����ͷ� �����մϴ�.
            string json2 = File.ReadAllText(path);

            QuestList loaded = JsonUtility.FromJson<QuestList>(json2);

            Debug.Log($"����Ʈ ���� : {loaded.quests[0].quest_name}");
        }
        else
        {
            Debug.LogWarning("�ش� ��ο� ����� JSON ������ �����ϴ�.");
        }
    }
}   


using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventSample : MonoBehaviour
{
    // �� ���� �ν����Ϳ��� �ʵ� ���� ���콺�� �÷��� �� ������ ������ �� �ֽ��ϴ�.
    [Tooltip("�̺�Ʈ ����Ʈ�� �߰��ϰ�, ������ ����� ���� ���� ������Ʈ�� ����ϼ���.")]
    public UnityEvent action;

    public PlayerStat stat; // ���� �� �ִ°� �־�� �Ѵ�. public Job myjob ó�� �ʿ�

    public BirthDay birthDay;

    public Mbti mbti;

    public enum Mbti
    {
        INFP,
        ENFP
    }

    [SerializeField]
    public int year = 2000;

    private void Update()
    {
        action.Invoke(); // �׼ǿ� ��ϵ� �Լ��� �����մϴ�.
    }

    public void Move()
    {
        gameObject.transform.Translate(0, 1, 0);
    }


    

    [Serializable]
    public class BirthDay
    {
        
        public int month;   
        public int day;
    }



    [Serializable]
    public class PlayerStat
    {
        public string name;
        public int Hp;
        public int Mp;
        public Mbti mbti;
        
    }
}

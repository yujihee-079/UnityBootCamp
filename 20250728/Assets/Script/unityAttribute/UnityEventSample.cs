using System;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventSample : MonoBehaviour
{
    // 툴 팁은 인스펙터에서 필드 값에 마우스를 올렸을 대 설명을 보여줄 수 있습니다.
    [Tooltip("이벤트 리스트를 추가하고, 실행할 기능을 가진 게임 오브젝트를 등록하세요.")]
    public UnityEvent action;

    public PlayerStat stat; // 담을 수 있는게 있어야 한다. public Job myjob 처럼 필요

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
        action.Invoke(); // 액션에 등록된 함수를 실행합니다.
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

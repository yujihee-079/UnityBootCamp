using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RandomQuiz : MonoBehaviour
{
    public int randQuiz;
    public Button button1;
    public Button button2;
    public Button button3;

    public void OnPointerDown(PointerEventData eventData)
    {
        int randQuiz = UnityEngine.Random.Range(1, 3); // 'Random'은(는) 'UnityEngine.Random' 및 'System.Random' 사이에 모호한 참조입니다.오류 발생!!

        switch (randQuiz)
        {
            case 1:
                Console.WriteLine("강아지는 뭐라고 말해요?");
                return;
                case 2:
                Console.WriteLine("고양이는 뭐라고 말해요?");
                return;
                case 3:
                Console.WriteLine("앵무새는 뭐라고 말했을까요?");
                return;
        }
    }

    private void Start()
    {
        button1.onClick.AddListener(멍멍);
        button2.onClick.AddListener(야옹);
        button3.onClick.AddListener(주인아_배고파);
    }
    private void 멍멍()
    {
        throw new NotImplementedException();
    }

    private void 야옹()
    {
        throw new NotImplementedException();
    }

    private void 주인아_배고파()
    {
        throw new NotImplementedException();
    }

}

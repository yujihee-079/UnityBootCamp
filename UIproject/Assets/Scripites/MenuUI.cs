using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject RuleUI;

    public void Start()

    {
        button1.onClick.AddListener(GameStart1);
        button2.onClick.AddListener(RuleView);
        button3.onClick.AddListener(GameExit);
    }

    private void GameExit()
    { // C# 전처리기 지시문 조건부 컴파일
#if UNITY_EDITOR
        EditorApplication.Exit(0); //정상적으로 종료합니다.*에디터
#else
Application.Quit();
#endif
    }

    private void RuleView()
    {
        RuleUI.SetActive(true); 
    }

    private void GameStart1()
    {//씬 이동
        //유의사항 : 씬이 유니티 에디터에서 등록되어 있어야 합니다.
        SceneManager.LoadScene("SampleScene");
    }
}

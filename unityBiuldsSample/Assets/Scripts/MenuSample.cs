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

    private void Start()
    {
        button1.onClick.AddListener(GameStart);
        button2.onClick.AddListener(RuleView);
        button3.onClick.AddListener(GameExit);
    }

    private void GameExit()
    {
#if UNITY_EDITOR
        EditorApplication.Exit(0); //정상적으로 종료합니다.
#else
        Application.Quit();
#endif
    }

    private void RuleView()
    {
        RuleUI.SetActive(true);
    }

    private void GameStart()
    {
        //씬이동
        SceneManager.LoadScene("SampleScene");
    }
}
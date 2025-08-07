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
    { // C# ��ó���� ���ù� ���Ǻ� ������
#if UNITY_EDITOR
        EditorApplication.Exit(0); //���������� �����մϴ�.*������
#else
Application.Quit();
#endif
    }

    private void RuleView()
    {
        RuleUI.SetActive(true); 
    }

    private void GameStart1()
    {//�� �̵�
        //���ǻ��� : ���� ����Ƽ �����Ϳ��� ��ϵǾ� �־�� �մϴ�.
        SceneManager.LoadScene("SampleScene");
    }
}

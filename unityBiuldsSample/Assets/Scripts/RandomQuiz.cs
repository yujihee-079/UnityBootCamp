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
        int randQuiz = UnityEngine.Random.Range(1, 3); // 'Random'��(��) 'UnityEngine.Random' �� 'System.Random' ���̿� ��ȣ�� �����Դϴ�.���� �߻�!!

        switch (randQuiz)
        {
            case 1:
                Console.WriteLine("�������� ����� ���ؿ�?");
                return;
                case 2:
                Console.WriteLine("����̴� ����� ���ؿ�?");
                return;
                case 3:
                Console.WriteLine("�޹����� ����� ���������?");
                return;
        }
    }

    private void Start()
    {
        button1.onClick.AddListener(�۸�);
        button2.onClick.AddListener(�߿�);
        button3.onClick.AddListener(���ξ�_�����);
    }
    private void �۸�()
    {
        throw new NotImplementedException();
    }

    private void �߿�()
    {
        throw new NotImplementedException();
    }

    private void ���ξ�_�����()
    {
        throw new NotImplementedException();
    }

}

using System;
using UnityEngine;

public class ActionFuncExample : MonoBehaviour
{
    //Action<T>�� �ִ� 16���� �Ű������� ���� �� �ֽ��ϴ�.
    //��ȯ���� �����ϴ�. void
    //������ �����̸�, ����� ���� �ʴ� ����
    public Action<int> myactuion;
    public Action<int,string> myaction2;

    //Func�� �������� ������ �κ��� Func�� ����� �Լ��� ��ȯ Ÿ���Դϴ�.

    public Func<bool> func01;
    public Func<string, int> func02;

    int result(string s) => int.Parse(s); // ���� ��ȯ ���ڿ� --> ������

    bool AttackAble()
    {
        int rand = UnityEngine.Random.Range(0, 10);
        return rand <= 3 ? true : false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myactuion += Rage;
        myaction2 += Heal;
        // �ʵ� ������ Action<int> ������ rage�� �°�, Action2<int, string>������ heal�� �´�!

        myactuion(50);
        myaction2(40, "Steve");

        func01 = AttackAble;

        if (func01())
        {
            Debug.Log("���� ����");
        }
        else
        {
            Debug.Log("���� ����!");
        }

        func02 = result;

        int point = func02("14");

        func01 = () => point > 10 ? true : false; // �� �� ����
    }

    void Rage(int value)
    {
        Debug.Log($"�г�� ���� ���ݷ���<color=red><b> {value}</b></color>��ŭ ����մϴ�!");
    }

    void Heal(int value, string character)
    {
        Debug.Log($"ȸ�� ��������<color=yellow><b> {character}</b></color> <color=green><b>{value}</b></color>��ŭ ȸ���մϴ�!");
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}

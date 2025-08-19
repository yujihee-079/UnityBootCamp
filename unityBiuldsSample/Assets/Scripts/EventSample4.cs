using UnityEngine;
using System;
using UnityEditor.Rendering;

//1. EventArgs�� ����� Ŀ���� Ŭ���� �����
public class DamagEventArgs : EventArgs
{
    //������ ���� ���� ����(������Ƽ�� �۾��ϸ�, get ��ɸ� �ַ� Ȱ��ȭ �մϴ�.)
    public int Value { get; } //value�� ���� ���ٸ� ����
    public string EventName { get; }

    //EventArgs�� ���� ������ �߻��ϸ� ���� �����˴ϴ�.(������)
    public DamagEventArgs(int value , string eventName)
    {
        Value = value;
        EventName = eventName;
    }
}
public class EventSample4 : MonoBehaviour
{
    public EventHandler<DamagEventArgs> OnDamaged; // �������� �޾��� ���� ���� �̺�Ʈ �ڵ鷯

    public void TakeDamage(int value, string eventName)
    {
        OnDamaged?.Invoke(this, new DamagEventArgs(value,eventName));

        Debug.Log($"<color=red>[ ��� ! ] �÷��̾ {value} �������� �޾ҽ��ϴ�.</color>");
    }

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage(UnityEngine.Random.Range(10,200),"���� ����");
        }
    }
}

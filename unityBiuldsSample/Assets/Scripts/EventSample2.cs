using System;
using UnityEngine;

//EventSample�� ������Ʈ�� �پ� �ִ� ��ü�� ������ �ְڽ��ϴ�.
public class EventSample2 : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ٸ� Ŭ�������� �̺�Ʈ�� �����ϴ� ���

        // Ŭ���� ����
        EventSample event_sample = GetComponent<EventSample>();

        //Ŭ������ ���� �̺�Ʈ�� �߰�
        event_sample.OnSpaceEnter += OnSpaceButton;
    }

    private void OnSpaceButton(object sender, EventArgs e)
    {
        Debug.Log("<coler=bule>Sample2���� ����� ���!</color>");
    }
}

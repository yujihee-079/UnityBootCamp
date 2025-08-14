using System;
using UnityEngine;
// C# event 526 page
// event : Ư�� ��Ȳ�� �߻����� �� �˸��� ������ ��Ŀ����
// 1. �÷��̾ �׾��� �� �˸� ���� -> �޼ҵ� ȣ��

//                        Action vs event Action?
//                  Action           vs            event Action
// �ܺ�ȣ��             O                               x
// �ܺ� ����            O                               x
// ���� ���            O                               O
// ���� ���            O                               O
// �� �뵵        ���η���, �ݹ�                   �̺�Ʈ �˸�


public class EventExample : MonoBehaviour
{
   

    public Action onDeath;
    public event Action onStart;

    private void Start()
    {
        //�׼��� +=�� ���� �Լ�(�޼ҵ�)�� �׼ǿ� ����� �� �ֽ��ϴ�.  [ ���� ]
        //�׼��� -=�� ���� �Լ�(�޼ҵ�)�� �׼ǿ��� ������ �� �ֽ��ϴ�.  [ ���� ]
        //�׼��� ����� ȣ���ϸ� ��ϵǾ��ִ� �Լ��� ���������� ȣ��˴ϴ�.
        onStart += Ready;

        onStart += Fight;

        onDeath += Damaged;

        onDeath += Dead;

        onStart?.Invoke(); // onStart�� ��ϵ� ����� �����ϴ� �ڵ� Invoke(); 
        onDeath?.Invoke();
        // onStart();   onDeath();   -> �Լ�ó�� �ڱ��ڽ��� ȣ���ϴ� ���� ����
        // ���� ����? ����. ���� ��Ÿ�� ����
        // ?.invoke ����̸� null üũ ����. �ܺο����� ȣ��, ������ �䱸 �� ��õ
        // �Լ� ���¸� ���� ����, ���� �ڵ��̰ų� �ܼ� ȣ���� ��� �ش� ��� ��õ
        //if( onStart != null)�� �߰��ϸ� ���� invoke�� �����ϰ� ���
    }

    private void Fight()
    {
        Debug.Log("<color=yellow><b> Fight!!</b></color>");
    }

    private void Ready()
    {
        Debug.Log("<color=cyan><b> Ready?</b></color>");
    }

    private void Dead()
    {
        Debug.Log("<color=red><b> A Hero is fallen.</b></color>");
    }

    private void Damaged()
    {
        Debug.Log("<color=blue><b> Critcal Damage!</b></color>");
    }
}

using UnityEngine;
using UnityEngine.Events;
//unityEngine.Events ���ӽ����̽� ������ �ʼ��Դϴ�.

//c#�� Enent���� ������
//1.�ν����Ϳ��� Ȯ���� �����ϴ�.
//2.�߰� ����� += , -= ���� ���� �ʰ� add_listener�� RevoveLister�� �����մϴ�.

/*
                        unityaction     vs      unityevent
    Ÿ��                 delegate                class
    ���                 �Լ�����                �����Ϳ��� �ڵ鷯 ���� ��� ����
    ����                 + , -                   AddListener(). RemoveSistener()
    ����� ��Ȳ     ��ũ��Ʈ �ڵ� �� ����        �ν����Ϳ� �̺�Ʈ �ý���
    �ӵ�                 ����                    ���� ( @���� ������ ���� �Ľ� �� ��Ÿ�� ���� ���)
    �޸�               ����                    ����
    GC �߻� ����         ����                    ����
    ���Ǽ�          ��ü ���� �ؾ� ��            �ٷ� ��� ����, ���� ����. 

UnityAction�� UnityEvent�� ����ϴ� �ڵ带 ������ �� ȿ�����Դϴ�.
�Ϲ� delegate�� UnityActon<T>�� ���� Ÿ�Կ� ���� ������ ���� �ȵǾ��־� ���� ���� ����ؾ� �մϴ�.

����� �� �ִ� ������
1. c#�� Delegate
2. Unity�� UnityAction
3. c@�� Func<T>, Action<T>

�� �پ��� delegate���� 
���� ��� ����ؾ� �ϴ°�..?

������ ���Ѵ� --> c#delegate
�ݹ�                Action, UnityAction
unityEvent���� ---> unityAction
�ν����� ����    
�̺�Ʈ �ñ״�ó --> delegate, Func(Return), Action
�ʿ�;             (�����ϰ� ����)

�̺�Ʈ �ñ״�ó:
ȣ��Ǵ����� ������ �Լ��� ����
C#�� EventHandler�� ����
ew)delegate void EventHandler(object sender, EventArgs e );

�ñ״�ó
1. ��ȯŸ��
2. �Ű�����
 */
public class EventSample3 : MonoBehaviour
{
    public UnityEvent ONKBunttonEnter;
    public UnityAction OnAction;

    private void Start()

    {
        //ONKBunttonEnter += sample ( @ ����)
        ONKBunttonEnter.AddListener(Sample);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ONKBunttonEnter?.Invoke();
        }

    }

    private void Sample()
    {
        Debug.Log("<color=cyan>Sample ����</color>");
    }
}

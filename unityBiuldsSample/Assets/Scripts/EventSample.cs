using System;
using UnityEngine;
/*
 * c#�� �̺�Ʈ ����
 * Ŭ���̳� ��ġ�� ���� ������ ó���ϴ� �ϳ��� �ý���
 * 
 * ������
 * ������� �ൿ�� ��ٸ��ٰ� �����ڿ��� �˷��ִ� ������ �����մϴ�
 * 
 * ������ 
 * �̺�Ʈ �����ڿ� ���� ������ ���� ������� �ൿ�� ���޹޾Ƽ� �����ϴ� ������ �����մϴ�
 * 
 * �������� ��� �������� �ൿ ��ü�� �����ڰ� �˾ƾ��� �ʿ�� ���� ����
 * �������� ��� ���к��ϰ� ������ ��� ���� �����ڵ��� ����� ����� �� ����
 * 
 * �̺�Ʈ ����� ���ؼ� �ý��� ���ӽ����̽��� ����ؾ� �մϴ�.
 * 
 * Edit - project setting���� ������ Both �� �ٲٱ�
 */

public class EventSample : MonoBehaviour
{
    public event EventHandler OnSpaceEnter;
    // eventhandler�� ��� ��ġ�� Ŭ������ �̺�Ʈ�� �����ϴ� �뵵
    // �̺�Ʈ ������ �̸��� ���� On + ���� / ������ ����� ���ϴ�.
    //��������Ʈ

    /*
      c#���� �������ִ� delegate Ÿ��
    EventHandler�� ��� ��ġ�� Ŭ�� ���� �̺�Ʈ�� �����ϴ� �뵵
    �Ű�����
    Object sender <- object Ÿ���� �����͸� ���޹��� �� ������,
    �̺�Ʈ�� �߻���Ų ����� �ǹ��մϴ�

    EventArgs e < - �̺�Ʈ�� ���õ� �����͸� ��� �ִ� ��ü�� �ǹ��մϴ�.
    �ش� ���� EventArgs �Ǵ� �ش� �ڽ� Ŭ������ �� �� �ֽ��ϴ�.
     */

    public void Start()
    {
        //���� ���
        // �̺�Ʈ�� += ���¿� �´� �޼ҵ� �̸�;
        OnSpaceEnter += Debug_OnSpaceEnter;
    }

    // Update is called once per frame
    void Update()
    {
        // 1)�̺�Ʈ ���� ��� �̺�Ʈ��(this.EventArgs.Empty)
        if (Input.GetKeyDown(KeyCode.Space)) //�����̽� ��ư Ŭ��
        { 
            //null �˻縦 �����ϰ� ���� (�̺�Ʈ ������ �ȵ����� ��쿡�� �����ϸ� �ȵǱ� ����)
            if (OnSpaceEnter != null)
            {
                OnSpaceEnter(this,EventArgs.Empty);
            }
            //this : �̺�Ʈ�� �߻���Ų ��ü(���� Ŭ����)
            //EventArgs.Empty : �̺�Ʈ ���࿡ �־� Ư���� �߰��Ǵ� �����Ͱ� ������ �ǹ��մϴ�.
        }

        //2)�̺�Ʈ ������ Invoke �Լ��� ����ϴ� ���
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            
           OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            // ?.�� ���� null�� �ƴ� �� ó���ǵ��� �Ѵ�.


            //int?������ Ÿ�԰� ���� �ڷ����� ?�� ���̰� Nullable �� Ÿ������ ����ϴ� ���
            //������������ null ���� ���� �� �ְ� ���� �� �ְ� ���ݴϴ�.(T?)
            //Ÿ���� ������ �� ���˴ϴ�.
            //�� ������ Ÿ�Կ� ���˴ϴ�.

            //Invoke?. �� ���·� ���̴� ���
            // null ���� �����ڷ� ���Ǵ� ���
            // ��ü�� null�� �ƴ� ���� ����� ���� ȣ���� �����ϵ��� �����մϴ�.
            //�޼ҵ�, �Ӽ�(property),�̺�Ʈ ���� ȣ�� �ÿ� ���˴ϴ�.
            //���۷��� ������ Ÿ�� �Ǵ� nullable ��ü�� ������� ����մϴ�.

            // >> iff(Obj != null ) ������ �ڵ� ��� ����մϴ�.

            //player?,Move();�� ���ؼ� �����Ͻÿ�.

            // �÷��̾ null�� �ƴ� ��쿡�� Move�� ȣ���մϴ�. null�̶��? ������.


        }
    }

    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow> ���� Ű �Է� �̺�Ʈ ����</coler>");
    }
}

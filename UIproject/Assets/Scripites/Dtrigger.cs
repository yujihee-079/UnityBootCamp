using System.Collections.Generic;//<T>
using System.Collections;
using UnityEngine;

public class Dtrigger : MonoBehaviour
{
    public List<Dialog> scripts;

    public void OnDTriggerEnter()
    {
        if (scripts != null && scripts.Count > 0)
        {
            DialogManager.Instance.StartLine(scripts);

            //Ŭ������.Instance.�޼ҵ��()�� ���� Ŭ������ ���� �ٷ� ����� �� �ֽ��ϴ�.
            //���� ���� GetComponent�� public��� ����ؼ� ����� �ʿ䰡 ���� ���մϴ�.

        }
    }
}

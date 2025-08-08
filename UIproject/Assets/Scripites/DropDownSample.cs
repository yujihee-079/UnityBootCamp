using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * ��� �ٿ��� �������
 * 1. Template : ��� �ٿ��� ���� ���� ��, ���̴� ����Ʈ �׸�
 * 2. Camtion / Item Text : ���� ���õ� �׸� / ����Ʈ �׸� ������ ���� �ؽ�Ʈ
 * TMP�� ���� ���, �ѱ� ����� ���� Label�� Item Label���� ��� ���� ��Ʈ��
 * ������ �ּž� ����� �� �ֽ��ϴ�.
 * 
 * 3. Option : ��� �ٿ ǥ�õ� �׸� ���� ����Ʈ
 *  �ν����͸� ���� ���� ����� �����մϴ�.
 *  ����ϸ� �ٷ� ����Ʈ�� ����˴ϴ�.
 *  
 *  4. On Value Changed : ����ڰ� �׸��� �������� �� ȣ��Ǵ� �̺�Ʈ
 *                        �ν����͸� ���� ���� ����� �� �ֽ��ϴ�
 *                        ��� �ٿ� ���� ���� ���� �߻� �� ȣ��˴ϴ�.
    */

public class DropDownSample : MonoBehaviour
{
    
    public TMP_Dropdown dropdown;
    // ����Ʈ�� �����.
    //Options�� ����� ���� ���ڿ�

    //����Ʈ<T>����Ʈ�� = new ����Ʈ��<T>{}�߰�ȣ {���, ���2, ���3};
    private List<string> options = new List<string> { "A", "B", "c" };

    private void Start()
    {
        dropdown.ClearOptions(); // dropdown�� option ����� �����ϴ� �ڵ�

        dropdown.AddOptions(options); // �غ�� ��ܿ� ���� �߰�

        dropdown.onValueChanged.AddListener(onDropdownValueChanged);
        // �̺�Ʈ ��� �� �䱸�ϴ� �Լ��� ���´�� �ۼ��� ��ٸ�
        // �Լ��� �̸��� �־� ����� �� �ְ� �˴ϴ�.
    }

    // c# system.in32 -> int
       // system.int64 -> long
       // system.Unt32 -> unsigned int (��ȣ�� ���� 32��Ʈ ����) (0���� 42����)

    void onDropdownValueChanged(int idx) // �䱸�ϴ� �Լ��� ����.
    {
        Debug.Log("���� ���õ� �޴��� "+ dropdown.options[idx].text);
        // �ɼ� ����Ʈ�� idx��° ���� ���� �ؽ�Ʈ
    }
}

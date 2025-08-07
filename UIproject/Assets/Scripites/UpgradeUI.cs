using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class UpgradeUI : MonoBehaviour
{
    public Button button01;
    public Text message;
    public Text icon_text;
    //�ڷ���[] �迭�� = New �ڷ���[]{
    //��, ��2, ��3
    //
    //};
    private string[] materials = new string[]
    {
        "100���",
        "100��� + ���",
        "200��� + �����̾� + ���¼�",
        "�ִ� ��ȭ �Ϸ�"
        };
    // max_Level�� ����� ��� �迭�� ���� -1�� ���� ������ �˴ϴ�.

    private int upgrade = 0;
    private int max_level => materials.Length - 1;
    // �迭���� �ε������ ������ �����մϴ�.
    //ex) materials�� �ϳ��� �����̰�, �ű⼭ 2��° �����ʹ� materials[1]�Դϴ�.
    // ī��Ʈ�� 0���� ��

    private void Start()
    {
        button01.onClick.AddListener(OnUpgradeBtnClick);
        //Add.Listener�� ����Ƽ�� UI�� �̺�Ʈ�� ����� �������ִ� �ڵ�
        //������ �� �ִ� ���� ���°� �������־ �� ���´�� ��������� �մϴ�.
        // �ٸ� ���·� ���� ���(�Ű������� �ٸ� ���)��� delegate�� Ȱ���մϴ�.
        // Ư¡ ) �� ����� ���� �̺�Ʈ�� ����� �����Ѵٸ�
        // ����Ƽ �ν����Ϳ��� ����� �� Ȯ�� �� �� �����ϴ�.

        //���� : ���� ������� �ʾƼ� �߸� ���� Ȯ���� �������ϴ�.
        UpdateUI();
        //���� �� UI�� ���� ������ ����
    }

    // ��ư Ŭ���� ȣ���� �޼ҵ� ����
    // ĸ��ȭ. �� �˾� �����⸦ ���� �� ���� �Դ´�.
    private void OnUpgradeBtnClick() // �Ű����� int a �� ���� ���ƾ��Ѵ�. �ذ����� �̺�Ʈ�Լ��� ����Ѵ�.
    {
        if (upgrade < max_level)
        {
            upgrade++;
            UpdateUI(); // Alt + Enter ������ �ٷ� �޼��� ����.
        }
    }

    private void UpdateUI()
    {
        icon_text.text = $"������ + {upgrade}";

        
            message.text = materials[upgrade].ToString();
        
    }
}

using System;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.UI;
public class Playerstats : MonoBehaviour
{
    public TMP_Dropdown player;

    public TMP_Text targetText;
    private List<string> strings = new List<string> { "����", "������", "����" };

    

    private void Start()
    {
        player.ClearOptions();

        player.AddOptions(strings);

       player.onValueChanged.AddListener(onDropdownValueChanged);

    }

    void onDropdownValueChanged(int idx)
    {
        Debug.Log("���� ���õ� �޴��� " + player.options[idx].text);
        // ���õ� �ؽ�Ʈ ��������
        string selectedText = player.options[idx].text;

        // �ٸ� TMP_InputField�� �ؽ�Ʈ �ֱ�
        targetText.text = ""+ selectedText;

        // ���ۿ� ���.


    }
}

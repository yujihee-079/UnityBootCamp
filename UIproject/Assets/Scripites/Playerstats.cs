using System;
using System.Collections.Generic;
using TMPro;

using UnityEngine;
using UnityEngine.UI;
public class Playerstats : MonoBehaviour
{
    public TMP_Dropdown player;

    public TMP_Text targetText;
    private List<string> strings = new List<string> { "전사", "마법사", "도적" };

    

    private void Start()
    {
        player.ClearOptions();

        player.AddOptions(strings);

       player.onValueChanged.AddListener(onDropdownValueChanged);

    }

    void onDropdownValueChanged(int idx)
    {
        Debug.Log("현재 선택된 메뉴는 " + player.options[idx].text);
        // 선택된 텍스트 가져오기
        string selectedText = player.options[idx].text;

        // 다른 TMP_InputField에 텍스트 넣기
        targetText.text = ""+ selectedText;

        // 구글에 물어봄.


    }
}

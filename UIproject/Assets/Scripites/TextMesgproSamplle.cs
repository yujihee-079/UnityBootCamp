using UnityEngine;
using TMPro;

public class TextMesgproSamplle : MonoBehaviour
{
    //TMP를 사용하는 UI 컴포넌트
    public TextMeshProUGUI textUI;

    public void Start()
    {
        //리치 텍스트(HML 태그 같은 느낌)제공
        textUI.text = "<size =150%>안녕하세요</size> <s>이 말 취소</s>";

    }

    public void SetText(bool warnig)
    {
        if (warnig)
        {
            textUI.text = "<color=red><b>WARNINg!!!</b><color>";

        }
        else
        {
            textUI.text = "<color = green>NORMAL</color>";
        }
    }
}

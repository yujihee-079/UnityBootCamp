using UnityEngine;
using TMPro;

public class TextMesgproSamplle : MonoBehaviour
{
    //TMP�� ����ϴ� UI ������Ʈ
    public TextMeshProUGUI textUI;

    public void Start()
    {
        //��ġ �ؽ�Ʈ(HML �±� ���� ����)����
        textUI.text = "<size =150%>�ȳ��ϼ���</size> <s>�� �� ���</s>";

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

using UnityEngine;
using UnityEngine.UI;

// 특정 키를 입력하면 텍스트에 특정 메세지가 나오도록 하는 코드

public class LegacyExample : MonoBehaviour
{
    /*
    private void Start()
    {
        text = GetComponentInChildren<Text>();
        // GetComponentInChildren<T>();
        // 한 오브젝트의 자식으로부터 컴포넌트를 얻어오는 기능
    }

   */


    /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "pata";

        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            text.text = "pong";
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            text.text = "";
        }
        
       
        // KeyCode 형태의 데이터 전체를 조사합니다. (필수 x)

        foreach (KeyCode Key in System.Enum.GetNames(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(Key))
            {
                switch (Key)
                {
                    case KeyCode.Escape:
                        text.text = "";
                        break;

                    case KeyCode.Return:
                        text.text = "pata";
                        break;

                    case KeyCode.Space:
                        text.text = "pong";
                        break;
                }
            }

        }
    }*/

}
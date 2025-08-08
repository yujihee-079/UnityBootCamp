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

            //클래스명.Instance.메소드명()과 같이 클래스의 값을 바로 사용할 수 있습니다.
            //따로 값을 GetComponent나 public등ㅇ로 등록해서 사용할 필요가 없어 편합니다.

        }
    }
}

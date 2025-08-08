using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/*
 * 드롭 다운의 구성요소
 * 1. Template : 드롭 다운이 펼쳐 졌을 때, 보이는 리스트 항목
 * 2. Camtion / Item Text : 현재 선택된 항목 / 리스트 항목 각각에 대한 텍스트
 * TMP를 쓰는 경우, 한글 사용을 위해 Label과 Item Label에서 사용 중인 폰트를
 * 수정해 주셔야 사용할 수 있습니다.
 * 
 * 3. Option : 드롭 다운에 표시될 항목에 대한 리스트
 *  인스펙터를 통해 직접 등록이 가능합니다.
 *  등록하면 바로 리스트에 적용됩니다.
 *  
 *  4. On Value Changed : 사용자가 항목을 선택했을 때 호출되는 이벤트
 *                        인스펙터를 통해 직접 등록할 수 있습니다
 *                        드롭 다운 값에 대한 변경 발생 시 호출됩니다.
    */

public class DropDownSample : MonoBehaviour
{
    
    public TMP_Dropdown dropdown;
    // 리스트로 만들기.
    //Options에 등록할 값은 문자열

    //리스트<T>리스트명 = new 리스트명<T>{}중괄호 {요소, 요소2, 요소3};
    private List<string> options = new List<string> { "A", "B", "c" };

    private void Start()
    {
        dropdown.ClearOptions(); // dropdown의 option 명단을 제거하는 코드

        dropdown.AddOptions(options); // 준비된 명단에 대한 추가

        dropdown.onValueChanged.AddListener(onDropdownValueChanged);
        // 이벤트 등록 시 요구하는 함수의 형태대로 작성이 됬다면
        // 함수의 이름을 넣어 사용할 수 있게 됩니다.
    }

    // c# system.in32 -> int
       // system.int64 -> long
       // system.Unt32 -> unsigned int (부호가 없는 32비트 정수) (0부터 42억쯤)

    void onDropdownValueChanged(int idx) // 요구하는 함수의 형태.
    {
        Debug.Log("현재 선택된 메뉴는 "+ dropdown.options[idx].text);
        // 옵션 리스트의 idx번째 값에 대한 텍스트
    }
}

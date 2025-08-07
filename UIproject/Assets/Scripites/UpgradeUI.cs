using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class UpgradeUI : MonoBehaviour
{
    public Button button01;
    public Text message;
    public Text icon_text;
    //자료형[] 배열명 = New 자료형[]{
    //값, 값2, 값3
    //
    //};
    private string[] materials = new string[]
    {
        "100골드",
        "100골드 + 루비",
        "200골드 + 사파이어 + 마력석",
        "최대 강화 완료"
        };
    // max_Level을 사용할 경우 배열의 길이 -1의 값을 가지게 됩니다.

    private int upgrade = 0;
    private int max_level => materials.Length - 1;
    // 배열에는 인덱스라는 개념이 존재합니다.
    //ex) materials가 하나의 묶음이고, 거기서 2번째 데이터는 materials[1]입니다.
    // 카운트를 0부터 셈

    private void Start()
    {
        button01.onClick.AddListener(OnUpgradeBtnClick);
        //Add.Listener는 유니티의 UI의 이벤트에 기능을 연결해주는 코드
        //전달할 수 있는 값의 형태가 정해져있어서 그 형태대로 설계행줘야 합니다.
        // 다른 형태로 쓰는 경우(매개변수가 다른 경우)라면 delegate를 활용합니다.
        // 특징 ) 이 기능을 통해 이벤트에 기능을 전달한다면
        // 유니티 인스펙터에서 연결된 걸 확인 할 수 없습니다.

        //장점 : 직접 등록하지 않아서 잘못 넣을 확률이 낮아집니다.
        UpdateUI();
        //시작 시 UI에 대한 렌더링 설정
    }

    // 버튼 클릭시 호출할 메소드 설계
    // 캡슐화. 예 알약 껍데기를 굳이 안 꺼내 먹는다.
    private void OnUpgradeBtnClick() // 매개변수 int a 를 적지 말아야한다. 해결방법은 이벤트함수를 사용한다.
    {
        if (upgrade < max_level)
        {
            upgrade++;
            UpdateUI(); // Alt + Enter 누르면 바로 메서드 생성.
        }
    }

    private void UpdateUI()
    {
        icon_text.text = $"마법사 + {upgrade}";

        
            message.text = materials[upgrade].ToString();
        
    }
}

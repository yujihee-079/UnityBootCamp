using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
// alt 누르고 방향키 누르면 코드를 옮길 수 있다.

public class UIEventCycle : MonoBehaviour,
    IPointerEnterHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    , IPointerExitHandler, // 포인터 관련

    IBeginDragHandler, IDragHandler, IEndDragHandler, // 드래그 관련

    ISelectHandler, IDeselectHandler,
    ISubmitHandler, ICancelHandler, // 선택과 취소

    IScrollHandler, //스크롤
    IUpdateSelectedHandler, // 선택 상태에서의  매 프레임에 대한 작업
    IMoveHandler // 키보드나 조이스틱 관련

// [class body]
{
    //필드
    private int eventCount = 0;
    private float lastEventTime = 0.0f;



    // 이벤트 처리용 함수

    //BaseEventData는 이벤트 시스템에서 
    private void Handle(string eventName, BaseEventData eventData)
    {
        eventCount++; // 카운트 증가
        float now = Time.time;//시간체크
        float delta = now - lastEventTime; //직전의 이벤트와의 시간 간격을 계산합니다.
        lastEventTime = now;

        string pos = ""; //받은 값이 PointerEventData일 경우 좌표에 대한 출력 처리

        // C# 패턴 매칭
        //1. eventData is PointerEventData --> 객체가 PointerEventData인지 확인
        //2. 맞으면 PointerData로 변환해서 지역 변수로 저장한다.

        if (eventData is PointerEventData pointerData)
        {
            pos = $"pos : {pointerData.position}";
        }

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append($"<color =yellow>{eventCount}</color>");// 이벤트 횟수
        stringBuilder.Append($"<b>{eventName})</b>");// 이벤트 명
        stringBuilder.Append($"<color = cyan>{delta:F3}</color>");// 이벤트 시간 간격
        stringBuilder.Append($"<color=blue{pos}</color>");// 좌표
        //F3 : Fixed-point(소수점 고정) 형태로 소수점 이하 3자리까지 표현하시오.
        //N2 : number에 대한 구분 1,234.57
        //D5 : Decimal(정수)에 대한 구분 012345
        //P1 : 퍼센트에 대한 사용 (값 * 100 이후 %를 붙인다.) { 0.34 : p1} --> 34%

        Debug.Log(stringBuilder.ToString());
        //이벤트 함수 이벤트명 좌표 간격

      
    }

    public void OnEnable()
    {
        eventCount = 0;
        lastEventTime=Time.time;
    }

    // 해당 이벤트가 발생할 때마다 Handle이 실행됩니다.
    // 실행하는 명령문이 1개일 경우 줄여서 표현가능
    // 접근제한자 반환타입 함수명(매개변수) => 실행 기능;
    public void OnBeginDrag(PointerEventData eventData) => Handle("Begin OnBeginDrag", eventData);


    public void OnCancel(BaseEventData eventData) => Handle("OnCancel", eventData);


    public void OnDeselect(BaseEventData eventData) => Handle("OnDeselect", eventData);


    public void OnDrag(PointerEventData eventData) => Handle("OnDrag", eventData);


    public void OnEndDrag(PointerEventData eventData) => Handle("OnEndDrag", eventData);



    public void OnMove(AxisEventData eventData) => Handle("OnMove", eventData);


    public void OnPointerClick(PointerEventData eventData) => Handle("OnPointerClick", eventData);


    public void OnPointerDown(PointerEventData eventData) => Handle("OnPointerDown", eventData);



    public void OnPointerEnter(PointerEventData eventData) => Handle("OnPointerEnter", eventData);


    public void OnPointerExit(PointerEventData eventData) => Handle("OnPointerExit", eventData);


    public void OnPointerUp(PointerEventData eventData) => Handle("OnPointerUp", eventData);



    public void OnScroll(PointerEventData eventData) => Handle("OnScrol", eventData);


    public void OnSelect(BaseEventData eventData) => Handle(" OnSelect", eventData);


    public void OnSubmit(BaseEventData eventData) => Handle(" OnSubmit", eventData);


    public void OnUpdateSelected(BaseEventData eventData) => Handle("OnUpdateSelected", eventData);


}


using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
// alt ������ ����Ű ������ �ڵ带 �ű� �� �ִ�.

public class UIEventCycle : MonoBehaviour,
    IPointerEnterHandler, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    , IPointerExitHandler, // ������ ����

    IBeginDragHandler, IDragHandler, IEndDragHandler, // �巡�� ����

    ISelectHandler, IDeselectHandler,
    ISubmitHandler, ICancelHandler, // ���ð� ���

    IScrollHandler, //��ũ��
    IUpdateSelectedHandler, // ���� ���¿�����  �� �����ӿ� ���� �۾�
    IMoveHandler // Ű���峪 ���̽�ƽ ����

// [class body]
{
    //�ʵ�
    private int eventCount = 0;
    private float lastEventTime = 0.0f;



    // �̺�Ʈ ó���� �Լ�

    //BaseEventData�� �̺�Ʈ �ý��ۿ��� 
    private void Handle(string eventName, BaseEventData eventData)
    {
        eventCount++; // ī��Ʈ ����
        float now = Time.time;//�ð�üũ
        float delta = now - lastEventTime; //������ �̺�Ʈ���� �ð� ������ ����մϴ�.
        lastEventTime = now;

        string pos = ""; //���� ���� PointerEventData�� ��� ��ǥ�� ���� ��� ó��

        // C# ���� ��Ī
        //1. eventData is PointerEventData --> ��ü�� PointerEventData���� Ȯ��
        //2. ������ PointerData�� ��ȯ�ؼ� ���� ������ �����Ѵ�.

        if (eventData is PointerEventData pointerData)
        {
            pos = $"pos : {pointerData.position}";
        }

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append($"<color =yellow>{eventCount}</color>");// �̺�Ʈ Ƚ��
        stringBuilder.Append($"<b>{eventName})</b>");// �̺�Ʈ ��
        stringBuilder.Append($"<color = cyan>{delta:F3}</color>");// �̺�Ʈ �ð� ����
        stringBuilder.Append($"<color=blue{pos}</color>");// ��ǥ
        //F3 : Fixed-point(�Ҽ��� ����) ���·� �Ҽ��� ���� 3�ڸ����� ǥ���Ͻÿ�.
        //N2 : number�� ���� ���� 1,234.57
        //D5 : Decimal(����)�� ���� ���� 012345
        //P1 : �ۼ�Ʈ�� ���� ��� (�� * 100 ���� %�� ���δ�.) { 0.34 : p1} --> 34%

        Debug.Log(stringBuilder.ToString());
        //�̺�Ʈ �Լ� �̺�Ʈ�� ��ǥ ����

      
    }

    public void OnEnable()
    {
        eventCount = 0;
        lastEventTime=Time.time;
    }

    // �ش� �̺�Ʈ�� �߻��� ������ Handle�� ����˴ϴ�.
    // �����ϴ� ��ɹ��� 1���� ��� �ٿ��� ǥ������
    // ���������� ��ȯŸ�� �Լ���(�Ű�����) => ���� ���;
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


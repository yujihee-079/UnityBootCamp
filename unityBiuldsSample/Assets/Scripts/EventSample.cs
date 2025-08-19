using System;
using UnityEngine;
/*
 * c#의 이벤트 이해
 * 클릭이나 터치에 따른 반응을 처리하는 하나의 시스템
 * 
 * 제공자
 * 사용자의 행동을 기다리다가 구독자에게 알려주는 역할을 진행합니다
 * 
 * 구독자 
 * 이벤트 제공자에 대한 구독을 통해 사용자의 행동을 전달받아서 반응하는 역할을 진행합니다
 * 
 * 구독자의 경우 구독자의 행동 자체를 제공자가 알아야할 필요는 따로 없음
 * 제공자의 경우 무분별하게 삭제할 경우 관련 구독자들이 기능을 사용할 수 없음
 * 
 * 이벤트 사용을 위해서 시스템 네임스페이스를 사용해야 합니다.
 * 
 * Edit - project setting에서 설정을 Both 로 바꾸기
 */

public class EventSample : MonoBehaviour
{
    public event EventHandler OnSpaceEnter;
    // eventhandler의 경우 터치나 클릭등의 이벤트를 관찰하는 용도
    // 이벤트 변수의 이름은 보통 On + 동사 / 시제로 만들어 집니다.
    //델리케이트

    /*
      c#에서 제공해주는 delegate 타입
    EventHandler의 경우 터치나 클릭 등의 이벤트를 관찰하는 용도
    매개변수
    Object sender <- object 타입의 데이터를 전달받을 수 있으며,
    이벤트를 발생시킨 대상을 의미합니다

    EventArgs e < - 이벤트와 관련된 데이터를 담고 있는 객체를 의미합니다.
    해당 값은 EventArgs 또는 해당 자식 클래스가 들어갈 수 있습니다.
     */

    public void Start()
    {
        //구독 방법
        // 이벤트명 += 형태에 맞는 메소드 이름;
        OnSpaceEnter += Debug_OnSpaceEnter;
    }

    // Update is called once per frame
    void Update()
    {
        // 1)이벤트 실행 방식 이벤트명(this.EventArgs.Empty)
        if (Input.GetKeyDown(KeyCode.Space)) //스페이스 버튼 클릭
        { 
            //null 검사를 진행하고 실행 (이벤트 구독이 안되있을 경우에는 실행하면 안되기 때문)
            if (OnSpaceEnter != null)
            {
                OnSpaceEnter(this,EventArgs.Empty);
            }
            //this : 이벤트를 발생시킨 객체(현재 클래스)
            //EventArgs.Empty : 이벤트 실행에 있어 특별히 추가되는 데이터가 없음을 의미합니다.
        }

        //2)이벤트 실행방식 Invoke 함수를 사용하는 방식
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            
           OnSpaceEnter?.Invoke(this, EventArgs.Empty);
            // ?.을 통해 null이 아닐 때 처리되도록 한다.


            //int?데이터 타입과 같이 자료형에 ?를 붙이고 Nullable 값 타입으로 사용하는 경우
            //정수형이지만 null 값도 가질 수 있게 해줄 수 있게 해줍니다.(T?)
            //타입을 선언할 때 사용됩니다.
            //값 형태의 타입에 사용됩니다.

            //Invoke?. 의 형태로 쓰이는 경우
            // null 조건 연산자로 사용되는 경우
            // 객체가 null이 아닐 떄만 멤버에 대한 호출을 진행하도록 설정합니다.
            //메소드, 속성(property),이벤트 등의 호출 시에 사용됩니다.
            //레퍼런스 형태의 타입 또는 nullable 객체를 대상으로 사용합니다.

            // >> iff(Obj != null ) 형태의 코드 대신 사용합니다.

            //player?,Move();에 대해서 설명하시오.

            // 플레이어가 null이 아닌 경우에만 Move를 호출합니다. null이라면? 무반응.


        }
    }

    private void Debug_OnSpaceEnter(object sender, EventArgs e)
    {
        Debug.Log("<color=yellow> 엔터 키 입력 이벤트 실행</coler>");
    }
}

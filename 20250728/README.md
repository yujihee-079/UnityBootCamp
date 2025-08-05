# 유니티 스크립트 예제
> ## 목차
> 1. 유니티 생명 주기
>
> 2. 이벤트 함수 예시
>
> 3. 태그
>
> 4. 캐싱
>
> 5. 벡터
>
> 6. Attritbute
>
> 7. Input
>
> 8. 수학 Mathf
>
> 9. 회전, 타깃을 향해 회전등의 움직임
>    
> 10. 레이케스트

## 유니티의 생명주기
***
> 유니티에서는 프로그램의 실행부터 종료까지의 작업 영역을 함수로 제공합니다.

 
> 스크립트 내에서 이벤트 함수를 작성하고, 내부에 진행할 명령문을 작성하면 상황에 맞게 해당 기능이 수행됩니다.

 >코르틴 : 코드를 일시 중지하고 특정 조건이 충족될 때까지 실행을 늦출 수 있는 기능입니다. (예: 3초뒤에 오브젝트를 파괴합니다.)

### 이벤트 함수 예시
|제목|내용|설명|
|------|---|---|
|Awake| > 씬이 시작될 때 한번만 호출 <br/> 각 스크립트를 기준 한번만 호출이 되고 다른 개체의 초기화가 완료 된 후 호출되는 영역이기 때문에 다른 컴포넌트에 대한 참조를 만들어야 하는 경우 이 위치에서 만들면 안전하게 처리 |해당 스크립트가 비 활성화 되어 있어도 이 위치의 작업은 실행됨.<br/> 해당 영역에서 코루틴으로 실행이 불가능 함.|
|onEnable|오브젝트 또는 스크립트가 활성화 될 떄 호출|이벤트에 대한 연결에 사용<br/> 코루틴 사용이 불가능하다.|
|Start|모든 스크립트의 Awake가 다 실행된 이후 실행|코루틴에대한 실행이 가능함|
|update |화면에 렌더링 되는 주기가 1초에 약 60번 정도 호출<br/> Time.deltaTime을 통해 이전 프레임 ~ 현재 프레임 까지의 시간 차이로 보정 값을 주거나 정규화 / 단위 벡터를 이용해 작업을 처리<br/> 프로그램 내에서 핵심적으로 계속 사용되는 메인 로직을 짜는 위치로 사용|키 입력 등을 기반으로 움직임,<br/> 지속적인 업데이트가 요구되는 경우|
|Fixedupdate|일정한 발생 주기가 보장되어야 하는 로직<br/> 물리 연산(Rigidbody)이 적용된 오브젝트에 대한 조정|프레임을 기반으로 처리되는 것이 아닌 Fixed TimeStep이라는 설정된 값에 의해 일정 간격으로 호출<br/> edit..project setting에 time에서 임의 설정 가능<br/> timeScale이 0으로 설정된 경우 멈춤|
|Lateupdate|모든 update(update, Fixdeupdate)함수가 호출이후 마지막으로 호출|후 처리 작업에 사용<br/> Lateupdate가 여러개일 경우 상황에 맞는 호출 순서가 중요함|

### Awke, start의 공통점
> 둘 다 기본적으로 값에 대한 초기화(할당)을 수행하는 위치.

 어떤 것을 사용해도 상관은 없으나 상황에 따라 설계함

 
 >Awake : 변수 초기화, 값 참조

 
 >Start : 게임 로직에 대한 실행, 초기화 된 데이터를 기반으로 작업 수행, 코루틴 작업

### 업데이트를 대체할 수 있는 수단
1. 상황에 맞는 유니티 생명 주기 코드

2. 코루틴

3. 이벤트 시스템(버튼 클릭 / 충돌 감지 등등)

4. c#의 가상 함수 개념(update를 대신해 특정 클래스에서 업데이트 로직을 처리함)<br/> 특정 하나의 관리 클래스 (manager)에 update의 로직을 위임해 관리해 사용

## 태그
> ### 1. Gameobject.FindwithTag("태그이름")
>
> 씬에서 해당 태그를 가지고 있는 오브젝트를 검색하는 기능
>
> 이 기능을 통해 받아 오는 값은 게임 오브젝트이다.
>
> ### 2. GameObject.GetComponent<T>.
>
> 게임 오브젝트는 GetComponent<T>를 통해 T에 컴포넌트의 유형을 작성해 주면 T가 가진 값을 가져온다.
>
## 오브젝트 캐싱 (objext Cashing)
> ### 1. 개념
>
> 자주 사용되는 데이터나 값을 미리 복사해두는 임시 장소
>
> ### 2. 사용 의도
>
> 1) 시간 지역성 : 가장 최근에 사용된 값이 다시 사용될 가능성이 높다.
>
> 2) 공간 지역성 : 최근에 접근한 주소와 인접한 주소의 변수가 사용될 가능성이 높다.
>
> ### 3. 예시:
>
>  ...클래스 생략 Rigidbody rb; <br/> Vector3 pos;(명명)   <br/> void start() { rb = GetComponent<Rigidbody>();}
>
>  void Update() { GetComponent<Rigidbody>().AddForce(pos * 5);
>
## 벡터

>### 벡터의 요소 n 벡터의 특징 n 벡터의 예시
>
> |제목|내용|
>|-----|------|
>|벡터의 요소| x == x축의 값 <br/> y == y축의 값 <br/> z == z축의 값 w == 쉐이더|
>|벡터의 특징| 1. 값 타입. <br/> 2. 값을 복사할 경우 값 그 자체를 복사하기만 한다. <br/> 3. 벡터에 대한 계산 보조 기능 (magnitude, normalized, dot, cross...) <br/> 4. 벡터 저장 영역은 스택 영역 메모리.|
>|벡터의 예시| public Vector 3 A = new Vector3() <br/> public Vector3 c = new Vector3(5,6,7) <br/> 또는 벡터를 선언하고, 새 함수에 "벡터" = A + C|

게임 오브젝트의 Transform을 통해 벡터 값을 구할 수 있다. 벡터는 필드에 안 쓴다.

 ## 부록 . 보간
 > ### 보간이란
>
> 해당 방향으로 일정 간격 천천히 이동함.
>
> public Transform target; <br/> public float speed = 1.of; private Vector3 start_position; <br/> private float t = 0.0f;<br/> private void Start() { start_position = transform.position;} <br/>private void Update(){if (t < 1.0f) { <br/> t += Time.deltaTime * speed; transform.position = Vector3.Slerp (start+position, tarfet.position, t);}}}
>
> ### 두 예시
>LinerInter | sphericaInter
>
> 선형 보간 방식인 리니어인터는 시간에 따라 직선으로 천천히 이동한다. 예를 들어 업데이트에 코드가 작성됐을 때 너무 빠르게 움직일 때 적용해 볼 수 있다.
> private void Update() <br/> { <br/> if ( t < 1.0f) 설명 : 조건문 조건이고 t는 앞에서 설정한 float t이다. <br/> { t += time.deltaTime * speed; 설명 : 시간 조건이 게임이 시작하고 천천히 증가하는 수치 만큼 스피드 수치를 곱하라는 뜻이다 <br/> transform.position = Vector3.Lerp ( start_position, target.position, t); 설명 이동하는 상태 조건이다. Lerp가 선형 보간 방식이고위 방식에는 ()안에 3가지 요소를 적어야 한다. 처음 시작한 장소, 목표로 하는 장소, 시간. <br/> }}}
>
>구면 선형 보간 방식인 슬러프는 시간에 따라 포물선을 그리며 이동한다. 위와 동일한데, Vector3.Slerp 로 바꿔쓰면 된다.
>
## Attribute
> 개념 : 클래스나 함수, 변수 앞에 붙는 [] 대괄호는 속성이라고 한다.
>
> 에디터에 대한 확장이나 사용자 정의 툴 제작에서 제공되는 기능들
>
> 목적 : 사용자가 에디터를 더 직관적으로 사용하려고 명령문을 넣어준다.
>
> |제목|형식|내용|
> |-----|-----|----|
> |AddComponentMenu|[AddComponentMenu("sample(그룹이름)/addcomponentMenu(기능이름)")]|에디트의 컴포넌트에 메뉴를 추가하는 기능<br/> 그룹만 넣거나 둘 다 지정 가능<br/> 순서는 특수 문자를 쓰면 제일 앞에 보이게 된다.|
> |ExecuteInEditMode|[ExecuteInEditMode]|에디터 모드에서 업데이트, OnEnable,onDisable 사용가능.<br/> 즉각적인 실행을 원할 때 == 게임 시작 버튼을 누르지 않았을 때 사용|
> |serializable|[System.serializable]또는 [Serializable] and [SerializeField]|사용자 정의 타입일 때 전자를 class 사용할 때 후자를 사용<br/>유니티에서 비공개(priviate)필드를 인스펙터(오른쪽 메뉴 화면)에 노출시키고 유니티의 직렬화 시스템에 포함시키는 기능|
> |textArea|[space][TextArea][TextArea(기본 표시 줄, 최대 줄)]|앞에 space는 안 넣어도 상관 없음. 적은 높이만큼 간격이 생김./ <br/> 긴 문자열을 여러 줄로 적을 수 있는 설정 <br/> textarea만 등록할 경우 여러 줄 입력이 가능한 상태가 된다.<br/> ()안에 정보를 넣어서 인스펙터 상에서의 높이를 제어한다. <br/> 문자열 길이에 대한 제한은 없음.
> |Range| [Range(최소, 최대)]|해당 값을 에디터에서 최소 값과 최대가 설정되어 있는 스크롤 형태의 값으로 변경. |
>
## 직렬화
> ### 개념 정의
>
> 데이터를 저장 가능한 형식으로 변환. 이 변환을 통해 씬, 프리팹, 에셋 등에 저장하고 복원할 수 있다
>
> ### 조건
>
> 1. public or [serializable]
>
> 2. static이 아닌 경우
>
> 3. 직렬화 가능한 데이터 타입인 경우 vs 불 가능한 데이터 타입인 경우
>
> |구분|데이터 형식|예|
>  |-----|----|-------|
>  |ㅕ|ㅐ|ㅕ|
   

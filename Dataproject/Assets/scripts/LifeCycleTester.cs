using System.Collections;
using UnityEngine;

// Umity ������ ����Ŭ�� ���� ���� ���� Ȯ�� �ڵ�
// Update�� Ȱ���� ������ �� ȣ���� ������� Ȯ���غ��ϴ�.

public class LifeCycleTester : MonoBehaviour
{
    private int count_per_frame = 0; // ������ ���� ȣ�� ī��Ʈ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Debug.Log("[Awake]������Ʈ�� ������ �� �ѹ��� ����Ǵ� ����");
    }

    private void OnEnable()
    {
        Debug.Log("[OnEnable]������Ʈ�� Ȱ��ȭ �� ȣ��Ǵ� ����");
    }

    private void Start()
    {
        Debug.Log("[Start] ù ������ ���� ���� ȣ��Ǵ� ����");
        StartCoroutine(CustomCoroutine());// �ڷ�ƾ ����
    }

    private void FixedUpdate()
    {
        Debug.Log($"[CPE : {count_per_frame}][FixedUpdate]������ ���� ������Ʈ�� ����Ǵ� ����");
    }

    // Update is called once per frame
    void Update()
    {
        count_per_frame++; // ī��Ʈ ����
        Debug.Log($"[CPE : {count_per_frame}] [Update] ���� ������ ���� ȣ���� ����Ǵ� ����");

        if (count_per_frame == 3)
        {
            Debug.Log($"[CPE : {count_per_frame}] [Test1] ������Ʈ�� ��Ȱ��ȭ �۾��� �����մϴ�.");
            gameObject.SetActive(false);
        }

        if (count_per_frame == 6)
        {
            Debug.Log($"[CPE : {count_per_frame} [test 2] ������Ʈ�� Ȱ��ȭ �۾��� �����մϴ�.]");
            gameObject.SetActive(true);

        }

        if (count_per_frame == 9)
        {
            Debug.Log($"[CPE : {count_per_frame} [test 3] ������Ʈ�� �ı� �۾��� �����մϴ�.]");
            Destroy(gameObject);
        }
    }

    private void LateUpdate()
    {
        Debug.Log($"[CPE : {count_per_frame} [Lateupdate] ��������, ���� ������ ��ó�� ]");
    }

    // �ڷ�ƾ ���� using System.Collections;
    // yield�� ���� ��� �� ����Ŭ�� ���ƿ��� ������ �����ϸ�, ���� UPdate�� ƴ���� ������ ����˴ϴ�.

    IEnumerator CustomCoroutine()
    {
        Debug.Log("[Coroutine] �ڷ�ƾ�� ���� ���� : StartCoroutine");
        yield return null;
        Debug.Log("[Coroutine] 1 ������ �� �ٽ� ����˴ϴ�.");

        yield return new WaitForSeconds(1.0f);
        Debug.Log("[Coroutine][Seconds] 1 �� �� �ٽ� ����˴ϴ�.");

        yield return new WaitForFixedUpdate();
        Debug.Log("[Coroutine][ForFixedUpdate]ForFixedUpdate�� ������ �ٽ� ����˴ϴ�");

        yield return new WaitForEndOfFrame();
        Debug.Log("[Coroutine][WaitForEndOfFrame]������ ���� ������ �ٽ� ����˴ϴ�");
    }

    private void OnDisable()
    {
        Debug.Log("[OnDisabl]������Ʈ�� ��Ȱ��ȭ �� ��� ȣ��Ǵ� ����");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy]������Ʈ�� �ı��Ǿ��� ��� ȣ��Ǵ� ����");

        // �� ��ġ������ �ı� ������ ����ǰ� �ֱ� ������ ������ ���� �۾��� �Ұ����մϴ�.
        // gameobject.SetActive(true/false) --> ������ �ǵ� ���������� �ǹ̰� ����. (���� ������ �ı� �� �ܰ迡�� ó��)
        // �ڱ� �ڽſ� ���� ���� �۾��� �Ұ����մϴ�. ��� �ı��˴ϴ�.
        // ���ο� ���� ������Ʈ�� �����ϴ� �۾��� �����մϴ�.
    }
}

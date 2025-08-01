using UnityEngine;
// Raycast : ���� ��ġ���� Ư�� �������� ������ ������ �i�� ��
// �ε����� ������Ʈ�� �ִ����� �Ǵ��մϴ�.
// 1) Ư�� ������Ʈ�� �浹 �������� �����ϴ� �۾� ����
// 2) Ư�� ������Ʈ�� ���� �浹 ������ Ȯ���ϴ� �뵵

public class RayCastSample : MonoBehaviour
{
    RaycastHit hit; //�浹 ������ ����

    // ref : ������ ������ ����, ������ �޼ҵ� �ȿ��� ���� �� �� ������ �˸��� �뵵.
    // out : ������ ���޵Ǵ� ��, ���� ���� ���� ������ ���� �ʱ�ȭ�� ������ �ʿ䰡 ����.

    // physics,Raycast ( Vector3 origin, Vector3 diretion, out RayCastHit hitInfo,
    // float maxDistance, int layerMask);

    // origin ���⿡�� dirction �������� maxDistance ������ ������ �߻��մϴ�. // ���� ������ ������ Ȯ�� �� �� ����.

    // hitinfo�� �浹ü�� ���� ������ �ǹ��մϴ�.

    const float length = 20.0f; // ���� ���� 5f --> 20f

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �� ���� ���� ���� ����ĳ��Ʈ �浹 ó��

        // �� �׸���
        Debug.DrawRay(transform.position, transform.forward * length, Color.red);
        // ���̾� ����ũ �����ϱ�
        int ignorelayer = LayerMask.NameToLayer("Red");
        int layerMask = ~(1 << ignorelayer);
        // �浹ü ����( ���� )
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, length, layerMask);
        //RaycastAll : �� �������� �� ���̰� �浹�� �浹ü�� �迭�� return

        for ( int i = 0; i < hits.Length; i++ ) // hits�� ���� (����)��ŭ �ݺ��� �����մϴ�.
        {
            Debug.Log(hits[i].collider.name + "�� hit�߽��ϴ�.");
            hits[i].collider.gameObject.SetActive(false);
            // hits �迭�� i��° ���� �浹ü�� ���� ���� ������Ʈ�� ��Ȱ��ȭ �մϴ�.
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        // ������Ʈ�� ��ġ���� �������� Length��ŭ�� ���̿� �ش��ϴ� ����� ������ ��� �ڵ�
        // �ַ� ����ĳ��Ʈ �۾����� ���̰� �Ⱥ��̱� ������ �����ִ� �뵵�� ����մϴ�.


        Debug.DrawRay(transform.position, transform.forward * length, Color.red); // ���� ī�޶� ���̴� ����
        

        // 1. �浹 ��Ű�� ���� ���� ���̾ ���� ���� ����

        int ignorelayer = LayerMask.NameToLayer("Red"); // �浹 ��Ű�� ���� ���� ���̾�

        // 2. ~(1 << LayerMask.NameToLayer("���̾� �̸�")) �ش� ���̾� �̿��� ��

        /*ex) ���࿡ Red���̾�� Blue ���̾ �� �� �����ϰ� ���� ���
         * int ignoreLayers = (1<<LayerMask.NameToLayer("Red")) | (1<<Layermask.NameToLayer("Blue"));
         * int layermasks = ~igmoreLayers;
         */

        int layerMask = ~(1 << ignorelayer); // ��Ʈ ����


        //���� ��ư�� ������ ��� ���� �߻�
        //  if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, length, layerMask)) // Max������ ����
            {
                Debug.Log("������ �߽�");
                Debug.Log(hit.collider.name);
                hit.collider.gameObject.SetActive(false);

                //���̾��ũ�� ��Ʈ ����ũ�̸�, �� ��Ʈ�� �ϳ��� ���̾ �ǹ��մϴ�.
                // 1 << n�� n��° ���̾ �����ϴ� ����ũ�� �ǹ��մϴ�.
                // ~�� ���� �ۼ��� ~(1<<n)�� �ش� ���̾ ������ ��� ���̾ �ǹ��մϴ�.
            }
        }
        //
    }
}

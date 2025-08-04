using System.Collections;
using UnityEngine;

public class UnitMoveAI : MonoBehaviour
{
    public float speed = 1.0f; // �̵� �ӵ�

    public float detection = 5.0f; // �˻� ����

    private Transform player_position; // �÷��̾� ��ġ

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_position = GameObject.FindGameObjectWithTag("player")?.transform;
        //?������ Ȱ�� : ��ü�� null�� �� �߻��� ���� ����
        // GameObject.FindGameObjectsWithTag("player")?.transform;�� ���� �ۼ��� �ϸ� �ش� ����
        // nullable Ÿ������ �����մϴ�.

        if (player_position != null)
        {
            StartCoroutine(Move());
        }
        else
        {
            Debug.LogWarning("���� ������ �÷��̾ ã�� �� �����ϴ�.");
        }

        IEnumerator Move()
        {
            while (player_position != null)
            {
                float distance = Vector3.Distance(transform.position, player_position.position);

                //�÷��̾ ������ �Ÿ� ���� �ִٸ� ?
                if(distance <= detection)
                {
                    Vector3 dir = (player_position.position - transform.position).normalized;

                    transform.position = Vector3.MoveTowards(transform.position, player_position.position, speed * Time.deltaTime); // �ܼ��� �� ai�� �÷��̾�� �ٰ��´�.
                }
                else
                {
                    // �Ÿ� ���� ���� �� �޼��� , �����, �ִϸ��̼� ���� ����� ������ ����
                }

                yield return null;
            }

        }

    }

   
}

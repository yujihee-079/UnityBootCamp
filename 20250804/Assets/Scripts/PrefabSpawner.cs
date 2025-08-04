using UnityEngine;
// 1. �������� ���� ����Ѵ�.
// 2. ������ ������Ʈ�� ���� ������ ���ο��� ������.
// 3. ���� �Ŀ� �ı��� ���� ������ �ð��� ������.

// �ش� ��ũ��Ʈ�� ���� ������Ʈ�� �����ϸ� , ������ �����ϰ� ���� �ð� �� �ı��ϵ��� ó���մϴ�.
// ����) �������� ����� �Ǿ� ���� �� �ش� �۾��� ����, �ƴ� ���
// ��� �޼����� �ȳ��մϴ�.
public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; // ���� ������ �ֱ� ������.

    private GameObject spawned;

    public float delay = 3.0f; // Ŭ���� �ȿ� �ִ� ������ �����.
    void Start()
    {
        if(prefab != null)
        {
            spawned = Instantiate(prefab);
            // ���� �ڵ� Instantiate() Ư¡ �����ε尡 ����.
            /* 
             * 1. Instantiate(prefab); �ش� �������� ������ �°� ��ġ�� ȸ�� �� ���� �����ǰ� �����ȴ�.
             * 2. Instantiate(prefab, transform.position, Quaternion.identity);
             *  --> �ش� �������� �����ϰ�, ��ġ�� ȸ�� ���� ������� ������Ʈ ��ġ�� ȸ�� ���� �����Ѵ�.
             *  3. Instantiate(prefab, parent); 
             *  ������Ʈ�� �����ϰ� �� ������Ʈ�� ������ ��ġ�� �ڽ����ν� ����մϴ�.
             *  4.Instantiate(prefab, transform.position, Quaternion.identity,parent);
             */

            spawned.name = "������ ������Ʈ "; // ������ ������Ʈ�� �̸��� �����ϴ� �ڵ�

            //spawned.AddComponent<Rigidbody>();
            //�� �� ������ ������Ʈ�� ������Ʈ�� �߰��մϴ�.

            Debug.Log(spawned.name + "�� �����Ǿ����ϴ�.");

            Destroy(spawned, delay); // delay �ð� ���� �ı� �ڵ��Դϴ�.
        }
        else
        {
            Debug.Log("��ϵ� �������� ���� �����ϴ�.");
        }
    }

    
}

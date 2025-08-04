using System.Collections;
using UnityEngine;

public class UnitySpawner : MonoBehaviour
{
    public GameObject unitPrefab; //���� ������

    public Transform spawnPoint; // ���� ��ġ

    public float interval = 5.0f; // ���� ���� ����

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            //������ �����մϴ�.
            //���� ��ġ�� spawnPoint�κ��� �޽��ϴ�.
           Instantiate(unitPrefab, spawnPoint.position,Quaternion.identity);

            //���� ���ݸ�ŭ ����մϴ�.
            yield return new WaitForSeconds(interval);



            Debug.Log($"{spawnPoint.name} + ���� {unitPrefab.name}�� �����˴ϴ�."); // ���� �����̴ϱ� ���ڿ� �������� �����. {unitPrefab.name}�� �ʵ��� ���� ������Ʈ�� ���Ѵ�. ���� ��� ť��
        }
    }
}

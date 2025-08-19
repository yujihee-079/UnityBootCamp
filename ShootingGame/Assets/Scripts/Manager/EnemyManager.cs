using UnityEngine;

//��ǥ : ���� �ð����� ���� ������ �� ��ġ�� ���� ��
// �ʿ��� ������ :1) ���� �ð� , ���� �ð�, �� ���� ����
//                 2) ���� �ð��� ���� �ð��� �ȴٸ�(�� Ÿ��  ��Ÿ��
//                  3) ���� �����մϴ�.

public class EnemyManager : MonoBehaviour
{
    float min = 1; 
    float max = 5;  // ��ȯ �ð� ����(�ִ� �ּ�) ���� �ֱ� ����

    float currenTime;
    public float createTime = 1;
    public GameObject enemyFactory;
    public GameObject spawnArea;// ���� ����

    private void Update()
    {
        currenTime += Time.deltaTime;

        if (currenTime > createTime)
        {
            var enemy = Instantiate(enemyFactory,spawnArea.transform.position,Quaternion.identity);
            //��ȯ ����(spawn area)�� ������ ������ ������,
            //���� ��ġ�� ȸ�� �� �������� �ʾƵ� �ȴ�.

            //������ ���� ���� �ִٸ� ���� ��ġ�������Ѵ�.
            currenTime = 0; // ������ �ð��� ������, �ٽ� ���ǹ��� üũ�� �� �ֵ��� �����մϴ�.
            createTime = Random.Range(min, max);
        }
    }
}

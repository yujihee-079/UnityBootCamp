using System.Collections.Generic;
using UnityEngine;

// ������Ʈ Ǯ�� (Object Pooling)
// ���� �����ǰ� �Ҹ�Ǵ� ������Ʈ�� �̸� ������ �����صΰ�
// �ʿ��� �� Ȱ��ȭ�ϰ� ������� ���� �� ��Ȱ��ȭ�ϴ� ������� ������ �����ϴ� ���� ����

// ��� ����)
// ź��, ����Ʈ, ������ �ؽ�Ʈ, ���� ó�� ���� �����ǰ� ������� ������
// �Ź� new , destory�� ���� ���� ������ �߻��ϸ� GC�� ���� ȣ��ǰ� �̴�
// ���� ���Ϸ� �̾��� �� �ֱ� ������ ���� ����� �������� ����մϴ�.

// ���� ) �߻� �Ѿ� �� 30�� / ������ ���� 20������ �̸� �ѹ��� �� ����
// �� ���� ���� �� Ȱ��ȭ

public class Bulletpool : MonoBehaviour
{

    public GameObject buller_prefab;

    public int size = 30;

    // Ǯ�� ���� ���Ǵ� �ڷ� ����
    // 1. ����Ʈ(List) �����͸� ���������� �����ϰ� , �߰�, ������ �����ӱ� ������ ȿ����
    // 2. ť (Queue) �����Ͱ� ���� ������� �����Ͱ� ���������� ������ �ڷᱸ���Դϴ�.
    private List<GameObject> pool;

    private void Start()
    {
        pool = new List<GameObject>(); // List�� �Ҵ�.

        for( int i = 0; i < size; i++ )
        {
            var bullet = Instantiate( buller_prefab );
            bullet.transform.parent = transform;
            // ������ �Ѿ��� ���� ��ũ��Ʈ�� ���� ������Ʈ�� �ڽ����� �����˴ϴ�.

            bullet.SetActive( false ); //�� Ȱ��ȭ ����

            bullet.GetComponent<Bullet>().Setpool(this);

            pool.Add( bullet ); 
            //����Ʈ��.Add(��) ����Ʈ�� �ش� ���� �߰��ϴ� ����
        }
    }// �Ѿ� ����

    

    public GameObject GetBullet()
    {
        //�� Ȱ��ȭ �Ǿ� �ִ� �Ѿ��� ã�Ƽ� Ȱ��ȭ �մϴ�.
        foreach( var bullet in pool )
        {
            // ���� â���� Ȱ��ȭ�� �ȵǾ��ִٸ�(����ϰ� ���� �ʴ´ٸ�
            if(bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }


        }
        //�Ѿ��� ������ ��쿡�� ���Ӱ� ���� ����Ʈ�� ����մϴ�.
        var new_bullet = Instantiate(buller_prefab);
        new_bullet.transform.parent = transform;
        pool.Add(new_bullet);
        return new_bullet;
    }

    public void Return(GameObject bullet)
    {
        bullet.SetActive(false);
    }
   

     
}



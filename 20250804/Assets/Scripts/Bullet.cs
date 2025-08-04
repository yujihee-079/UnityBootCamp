using System.Collections;
using UnityEngine;

// �Ѿ˿� ���� ���� , �Ѿ� �ݳ�, �Ѿ� �̵�

public class Bullet : MonoBehaviour
{
    public float speed =5.0f; // �Ѿ� �̵� �ӵ�

    public float life_time = 2.0f; // �Ѿ� �ݳ� �ð�

    public GameObject effect_prefab;  // ����Ʈ ������
    

    private Bulletpool pool; // Ǯ

    private Coroutine life_coroutine;

    public void Setpool(Bulletpool pool) // Ǯ �ʱ�ȭ Ǯ ����(Ǯ���� �ش� �� ȣ��)
    {
        this.pool = pool;
    }


    //Ȱ��ȭ �ܰ�
    private void OnEnable()
    {
        life_coroutine = StartCoroutine(BulleReturn());

    }
    
    //�� Ȱ��ȭ �ܰ�
    private void OnDisable()   //if�� �ۼ��� �� ���� ��� �߰�ȣ {} ���� �����մϴ�.
    {
        if (life_coroutine != null)
            StopCoroutine(life_coroutine);
    }

    private void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    IEnumerator BulleReturn()
    {
        yield return new WaitForSeconds(life_time);

        ReturnPool();
    }

    private void OnTriggerEnter(Collider other)
    {

        //�ε��� ����� Enemy �±׸� ������ �ִ� ������Ʈ�� ���
        // �������� �����ϴ�. �� ���� ������ ���� �ڵ� �ۼ�

        // ����Ʈ ����(��ƼŬ)
        ReturnPool();

        if(effect_prefab != null)
        {
            Instantiate(effect_prefab,transform.position,Quaternion.identity); // �̸�. ������ ����
            

        }


    }

    //�޼ҵ��� ����� ������ ��� , => �� ����� �� �ֽ��ϴ�.
    void ReturnPool() => pool.Return(gameObject);


}

using System.Collections;
using UnityEngine;

public class CortineSample : MonoBehaviour
{
    //������ Ÿ��
    public GameObject target;

    //��ȭ �ð�
    float duration = 5.0f;
    
    //�ٲٰ� ���� ��
    public Color color;

    // Coroutine coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Coroutine = StartCoroutine(ChangeColor());
        StopCoroutine(Coroutine);
        StoopCoroutine("ChangeColor"); ���ڿ�
        StopAllCoroutines(); ��� �ڷ�ƾ�� ���� ���� ( ���� ���� ������Ʈ���� ���� ����)
        */

        //Ÿ���� �����Ǿ� �ִٸ�
        if (target != null)
        {
            StartCoroutine(ChangeColer());
            //startCoroutione(�޼ҵ��()) IEnumerator ������ �޼ҵ带 �ڷ�ƾ���� �����մϴ�.
            //�ڵ� �ۼ��������� �޼ҵ尡 ������ ������.
            //�޼ҵ� ȣ���� ������ �������� Ȯ�εǱ⿡ ã�� �����ϴ� �ð��� ���ڿ����� ���� ��ϴ�.

            //StartCoroutine("ChangeColor");
            // StartCoroutine(�޼ҵ��()); ���ڿ��� ���� �Ű������� ���� �ڷ�ƾ�� ȣ���� �� �ֽ��ϴ�.
            /*
             * ���������� ���޼ҵ��� �̸��� ���ڿ��� �����ϰ�, ��Ÿ�ӿ��� ã�Ƽ� �����ϴ� ��� ( ���÷��� )
             * Ÿ�� üũ�� ���� �����Ƽ� �߸��� �̸��� ���� ��Ÿ�� ���� �߻�
             */
        }
        else
        {
            Debug.LogWarning("���� Ÿ���� ��ϵ��� ���� �����Դϴ�.");
        }
    }

    IEnumerator ChangeColer() // ������Ʈ�� ���ϴ� �ڵ�. ������ vs Ư�� ���� 
    {
        //Ÿ�����κ��� ������ ������Ʈ�� ���� ���� ���´�.
        var targetRenderer = target.GetComponent<Renderer>();

        // ������ Ÿ���� �������� ���� ���
        if (targetRenderer == null)
        {
            Debug.LogWarning("���� �������� ���� �����Դϴ�.");
            // �۾� �ߴ�
            yield break;
        }
        // �� ��ġ�� �ڵ�� ���������� �������� ���� ��쿡 ����Ǵ� ��ġ
        float time = 0.0f;

        // Ÿ���� �������� ���� ��Ƽ������ ������ ���
        var start = targetRenderer.material.color;
        var end = color;

        //�ݺ� �۾�
        //�ڷ�ƾ ������ �ݺ����� �����ϸ�, yield�� ���� ���������ٰ� �ٽ� ���ƿͼ� �ݺ����� �����ϰ� �˴ϴ�.

        while (time < duration) //��ȭ �ð���ŭ �۾�
        {
            time += Time.deltaTime;
            var value = Mathf.PingPong(time,duration) / duration;

            //Mathf.PingPong(a,b)
            //�־��� ���� a�� b ���̿��� �ݺ��Ǵ� ���� �����մϴ�. (��Ӻ����� �պ��)
            // �� 0~ 1 ������ ��ȭ ���� ���˴ϴ�.
            // ����ȭ �۾��� ������ ���� : color�� 0���� 1������ ��

            targetRenderer.material.color = Color.Lerp(start, end, value);  // Lerp�� A���� b���� ���� ������ �ε巴�� �̵��ϴ� �ڵ�
            // �� ���� ���� �ε巯�� ����

            yield return new WaitForSeconds(1.0f); // null �ϸ� �������� 1f�� �ٲ�.
            // ���� Time = 0.0f;�� �ʱ�ȭ�� ���ָ� ���� �ݺ���. ȿ���� ���� ���� �ƴ�.

            Debug.Log("�� �������� �������.");
        }
    }
    /* �ڷ�ƾ ���� ���
     * StopCoroutine(�ڷ�ƾ ��ü);
     */

   

    
}

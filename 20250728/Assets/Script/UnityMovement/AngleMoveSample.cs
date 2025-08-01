using UnityEngine;

// �÷��̾ 45�� �������� �����ϴ� �ڵ�

public class AngleMoveSample : MonoBehaviour
{
    [SerializeField]float angle_degree ; // ���� (��)
    [SerializeField]float speed; //(���ǵ�) �ӵ�, ������ �� �� ��ġ.

    

    // Update is called once per frame
    void Update()
    {
        var radian = Mathf.Deg2Rad * angle_degree ;
        Vector3 pos = new Vector3(Mathf.Cos(radian), 0, Mathf.Sin(radian));

        transform.Translate(pos *speed*Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Return))
        {
            transform.position = Vector3.zero;
        }

    }
}

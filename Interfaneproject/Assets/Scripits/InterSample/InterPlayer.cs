using UnityEngine;

public class InterPlayer : MonoBehaviour
{
    //�ν����� ������ ���� ���� ( ���� ������ ���� ���� )
    // �ܺο��� ���� �Ұ� ( �Ժη� �� ���� ����� �뵵 )
   [SerializeField] ScriptableObject attackObject;

    private IAttackStrategy strategy;

    private void Awake()
    {
        strategy = attackObject as IAttackStrategy;



        if (strategy == null)
        {
            Debug.LogError("���� ����� �������� �ʾҽ��ϴ�!");
        }

    }

   

    private void ActionPerformed(GameObject target)
    {
        strategy?.Attack(target);
        // Nullable<T> or T? �� value�� ���� null ����� ���� �����Դϴ�.
    }

}

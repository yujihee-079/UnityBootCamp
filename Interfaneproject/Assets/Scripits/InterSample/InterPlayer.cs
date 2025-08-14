using UnityEngine;

public class InterPlayer : MonoBehaviour
{
    //인스펙터 내에서 접근 가능 ( 내부 데이터 연결 목적 )
    // 외부에서 접근 불가 ( 함부로 값 쓰지 말라는 용도 )
   [SerializeField] ScriptableObject attackObject;

    private IAttackStrategy strategy;

    private void Awake()
    {
        strategy = attackObject as IAttackStrategy;



        if (strategy == null)
        {
            Debug.LogError("공격 기능이 구현되지 않았습니다!");
        }

    }

   

    private void ActionPerformed(GameObject target)
    {
        strategy?.Attack(target);
        // Nullable<T> or T? 는 value에 대한 null 허용을 위한 도구입니다.
    }

}

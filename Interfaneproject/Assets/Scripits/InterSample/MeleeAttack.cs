using UnityEngine;
[CreateAssetMenu(menuName = " Attack Strategy/Mellee")]
public class MeleeAttack : ScriptableObject , IAttackStrategy
{
    public void Attack(GameObject target)
    {
        Debug.Log("[Melee Attack]" +  target.name);
    }
   
}

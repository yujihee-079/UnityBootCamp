using UnityEngine;

public class Itemtester : MonoBehaviour
{
    public SOmaker SOmaker;

    private void Start()
    {
        Debug.Log(SOmaker.description);
    }

    public void LevelUp()
    {
        SOmaker.level++;
        Debug.Log("레벨이 증가했습니다!");
    }
}

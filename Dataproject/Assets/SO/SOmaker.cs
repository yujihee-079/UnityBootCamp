using UnityEngine;

//�����Ϳ��� �ش� ������Ʈ ���� ����
[CreateAssetMenu(fileName ="������", menuName = " item/ ������")]
public class SOmaker : ScriptableObject
{
    public enum ItemType { ���, �Һ�, ��Ÿ}


    public string item_name;

    public ItemType type;

    public string description;

    public int level;
}

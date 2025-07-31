using System.Collections.Generic;//c#���� �������ִ� �ڷᱸ��(List<> , dictionary<K,V>���� ��) ��� ����
using System;
using UnityEngine;

public class InspextorAttributes : MonoBehaviour
{
    [System.Serializable]
    public struct Book // ����� ���� Ÿ�� / value Ÿ�� /GC �ʿ� ���� ~~ ���α׷��� ���ǵ� Ÿ�� ~~ �߰����Ű� �ʿ� ����. /���� �������� ������ ���� �Ҵ� / �����ϴ� ���信�� Ȱ�� wx) vetor3 / ����ȭ�뵵
    {
        public string name;
        public string description;
    }

    [Serializable]
    public class Item 
        //��ü�� ���� ���赵(�Ӽ��� ���) / ����Ƽ������ class ��� ���� /���� ���������� �Ǽ� �߻� ���ɼ� ����.
    {
        public string name; 
        public string description;
    }

    [Header("Scrore")]
    public int point;
    public int max_point;
    [Header("Info")]
   
    public string nickname;

    public Job myJob;

    //�ν����Ϳ� �����ϱ� ���� ���� ���� ����
    [HideInInspector]
    public int value = 5;

    // ����Ƽ���� �����(priviate) �ʵ带 �ν����Ϳ� �����Ű�� ����Ƽ�� ����ȭ �ý��ۿ� ���Խ�ŵ�ϴ�.
    // ������
    // public  --> ���� + ���� ����
    // private  --> ���� x ���� x
    // [SerializeField + private ] --> ���� x, �ν����Ϳ����� ���� ����

    //* ����ȭ([SerializeField]) : �����͸� ���� ������ �������� ��ȯ�ϴ� �۾�
    // �� ��ȯ�� ���� ��, ������, ���� � �����ϰ� �����ϴ� �۾��� ���� �� �� �ֽ��ϴ�.

    // ����ȭ ����
    // 1. public or [SerializeField]
    // 2. static�� �ƴ� ���
    // 3. ����ȭ ������ ������ Ÿ���� ���

    // ����ȭ�� ������ ������
    // 1. �⺻ ������ (int, float, bool, string...)
    // 2. ����Ƽ���� �������ִ� ����ü ( Vector3, Quaternion, Color..)
    // 3. ����Ƽ ��ü ����(GameObject, Transform, Material)
    // 4. [Serializable] �Ӽ��� ���� Ŭ����
    // 5. �迭 / ����Ʈ

    // ����ȭ �Ұ����� ������ 
    // 1. dictionary<K,V>
    // 2. Interface (�������̽�) �̿ϼ� �������̱� ����.
    // 3.static Ű���尡 ���� �ʵ�
    //4. abstract Ű���尡 ���� Ŭ����

    [SerializeField]
    public int value2 = 7;

    //Space(����) : ���� ���̸�ŭ ������ ����ϴ�.

    //�� ���ڿ��� ���� �ٷ� ���� �� �ִ� ����
    // [textArea]�� ����� ��� ���� �� �Է��� ������ ���°� �˴ϴ�.
    // [TextArea(�⺻ ǥ�� ��, �ִ� ��]�� ���� �ν����� �󿡼��� ���̸� �����մϴ�.
    // ���ڿ� ���̿� ���� �������� �κ��� �����ϴ�.
    [Space(30)] [TextArea(3,5)]
    public string quest_info;

    public Book book;
    public Item item;  // public Item item



    // ����Ƽ �ν����Ϳ����� �迭�� ����Ʈ�� ������ �˴ϴ�.
    // ����Ʈ<T> T ������ �����͸� �������� ���������� ������ �� �ִ� �������Դϴ�.
    // �������� �˻�, �߰�, ���� ���� ����� �����˴ϴ�.
    public List<Item> item_list;

    public Book[] books = new Book[5];

    public enum Job 
        // public Job myjob
    {
        ����,����,�ü�,������
    }

    // Range(�ּ�, �ִ�)�� ���� �ش� ���� �����Ϳ��� �ּ� ���� �ִ밡 �����Ǿ� �ִ�
    // ��ũ�� ������ ������ ����˴ϴ�.(���� ����)
    [Range(0,100)]public int bg;
    [Range(0, 100)]public int sfx;

    
}

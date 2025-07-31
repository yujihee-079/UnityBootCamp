using UnityEngine;
using UnityEngine.InputSystem;

//player Input�� �����ؾ� ���

//[RequireComponent(typeof(T))]�� �� ��ũ��Ʈ�� ������Ʈ��
//����� ��� �ش� ������Ʈ�� �ݵ�� T�� ������ �־�� �մϴ�.
//���� ����� �ڵ����� ������ְ�, �� �ڵ尡 �����ϴ� ��
//�����Ϳ��� ���� ������Ʈ�� �ش� ������Ʈ�� ������ �� �����ϴ�.
/*
���� ��ǥ�� (World space)
�� ��ü�� �������� ����ϴ� ���� ��ǥ = > �������� ���� �������� �����̴� ���� �����ش�.

(0,0,0)�� ���� �߽���

 * x : �� ��
 * Y : �� �Ʒ�
 * z : �� ��
 * ���� ����
 * Ư¡ ��� ���� ������Ʈ�� ����
 * �ϴ� �������� ���� ����.
 * �� ������ ��𼭵� ���� ��ġ�� 
 * ������ ������ �˴ϴ�.
 * (0,0,1) ������ �̵�
 * 
 * ���� ��ǥ�� (Local Space)
 * Ư�� ������Ʈ ������ ��ǥ
 * ������Ʈ�� ��ġ, ȸ��, ũ�⸦ �������� ��ǥ�� ����
 * ������Ʈ�� ���⿡ ���� �����̰� ��.

*/

[RequireComponent(typeof(PlayerInput))]
public class InputSystemExample : MonoBehaviour
{
    //���� Action Map : Sample
    //     Action     : move
    //     Type       : Value
    //     Compos     : Vector2
    //     Binding    : 2D Vector(WASD)

    //send message�� ���Ǵ� ���
    //Ư�� Ű�� ������ , Ư�� �Լ��� ȣ���մϴ�.
    //�Լ� ���� On + Actions name, ���� ���� Actions�� �̸� Move���
    //�Լ����� OnMove�� �˴ϴ�.

    private Vector2 moveInputValue;
    private float speed = 3.0f;
    void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(moveInputValue.x,0,moveInputValue.y); // �¿� x�� ���� z��
         transform.Translate(move *  speed *Time.deltaTime); // ���� ��ǥ��� �����Ϸ��� space.World�� ���´�.
    }
}

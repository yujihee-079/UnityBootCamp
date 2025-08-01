using UnityEngine;
#region ����Ƽ�� ȸ��
// ����Ƽ�� ȸ�� (Rotate)
// 1. ���Ϸ� ��(Euler Angle)�� ���� ȸ�� - x, y, z ȸ�� ��
// ����Ƽ �ν����Ϳ����� transform ������Ʈ�� rotation�� ǥ��� �� (���� ����)
// ex ) Rotation x 120 y 45 z 0 --> x������ 120�� y������ 120 ȸ���Ǿ����� �ǹ��մϴ�.

// 2. ���ʹϾ�(Quaternion) - ȸ���� ����ϱ⿡ �������� �������� ����� ���� ��
//                           ����Ƽ ���� ���ο��� ������ ����ǰ� ���Ǵ� ��

// ��ó�Ͼ����� ó���ϴ� ����
// ����Ƽ���� ���� -> ���Ϸ� �� ��ȯ �� 360�� �̻��� ȸ���� ����� �� ����
// 380�� ȸ�� -> 360�� �� ������ ġ�� 30�� ȸ��

// ���� �� ���� (Gimbal Lock) : ���Ϸ�  ���� �̿��� ȸ���� ǥ���ϴ� ��쿡 �߻��ϴ� ȸ�� �������� �ս�

//                              --> � ���� �ٸ� ��� ���ĵǴ� ����, �� ���� ȸ���� ��ȿ�Ǹ鼭 ȸ�� ������ 3���� �ƴ� 2���� ���� ����

// ���ʹϾ��� ����

// 4���� ���Ҽ� (x, y, z, w(��Į��)) �ϳ��� ���� { x, y, z} �ϳ��� ��Į�� w 

// ���ʹϾ� ����ó�� ������ ���ÿ� ȸ���� ������ ������ �ֽ��ϴ�. ( ���ʹ� ��ġ�̸鼭 ������ ���� )

// �� ���� ���ÿ� ȸ������ ���� �� ������ �߻����� �ʵ��� �����Ǿ� ���� ( x, y, z�� �׻� ���ÿ� ��ȭ�Ѵ�)

// ���ʹϾ��� ȸ���� ������ ������ ���� ȸ���� ������ �� �ֽ��ϴ�.

// orientation : ����

// ���� : 180�� �̻��� ǥ�� �Ұ�

//        ���������� �����ϱ� ����� ���� 
#endregion


public class ObjectRotate : MonoBehaviour
{
    
   
    // Update is called once per frame
    void Update()
    {
        /*transform. Rotate()�� ȸ���� �����Ű�� ���� �⺻���� �ڵ�
         *transform. Rotate(Vector3 eulerAngles); ������ ���� �������� ȸ��
         *transform. Rotate(float x, float y, float z) ; //����(���� ������Ʈ) ������ ȸ��
         *transform. Rotate(Vector3 axis, float angle) : //Ư�� ���� �߽����� ȸ��
         **transform. Rotate(Vector axis, float angle, space space) : // ���� �Ǵ� ���� �߿� ����
         *
         *���� �������� z������ 60����ŭ ȸ���ض�
         *transform. Rotate(Vector3.forward, 60f * Time.deltTime, space.World);
         *
         *���� ������Ʈ�� �������� ȸ���� �����մϴ�.
         *transform.Rotate(new Vector4(20,20,20,) * Time.deltaTime);
         *
        */

        // ���� ��ǥ�� �������� ȸ���� �����մϴ�.
        transform.Rotate( new Vector3(20, 20,20)* Time.deltaTime, Space.World );   
    }
}

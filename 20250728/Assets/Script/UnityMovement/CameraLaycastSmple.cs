using UnityEngine;
// ī�޶� �������� ���콺 Ŭ�� ��ġ�� ����ĳ��Ʈ ó��

public class CameraLaycastSmple : MonoBehaviour
{
    
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)) // Ŭ���ؼ� ���ο�� �ٲٴ� ���
        {
            // Ray ray = new Ray(��ġ, ����)

            //ī�޶󿡼� ����� ���̸� ���� ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit) )
            {
                Debug.Log("�� ���� ������̾�!");
                hit.collider.GetComponent<Renderer>().material.color = Color.yellow;
                
                // �浹ü ������Ʈ�� ���� ����
                var hitObject = hit.collider.gameObject;

                int change_layer = LayerMask.NameToLayer("Yellow");

                // ���̾ ��ȿ�� ���� ���

                if (change_layer != -1)
                {
                    hitObject.layer = change_layer;

                }
            }
        }
    }
}

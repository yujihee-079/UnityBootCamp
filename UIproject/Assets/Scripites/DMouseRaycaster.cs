using UnityEngine;
using UnityEngineInternal;

public class DMouseRaycaster : MonoBehaviour
{
    private Camera cam;

    public float distance = 10.0f;

    public LayerMask layerMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, distance, layerMask))
            {
                //트리거 체크
                var trigger = hit.collider.GetComponent<Dtrigger>();

                if (trigger != null)
                {
                    //트리거를 통한 다이얼로그
                    trigger.OnDTriggerEnter();
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCheck : MonoBehaviour
{
    private Camera cam;
    public LayerMask mask;

    private void Awake()
    {
        cam = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
        //Draw Ray
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 1000f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000, mask))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}

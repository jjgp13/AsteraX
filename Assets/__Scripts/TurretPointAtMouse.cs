//#define DEBUG_TurrentPoint_DrawMousePoint

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPointAtMouse : MonoBehaviour {

#if DEBUG_TurrentPoint_DrawMousePoint
    public bool DrawMousePoint = false;
#endif

    private Vector3 mousePoint;

    // Update is called once per frame
    void Update () {
        PointAtMouse();
    }
    
    void PointAtMouse()
    {
        mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        transform.LookAt(mousePoint, Vector3.back);
    }

#if DEBUG_TurrentPoint_DrawMousePoint
    private void OnDrawGizmos()
    {
        if(DrawMousePoint && Application.isPlaying)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(mousePoint, 0.2f);
            Gizmos.DrawLine(transform.position, mousePoint);
        }
    }
#endif

}
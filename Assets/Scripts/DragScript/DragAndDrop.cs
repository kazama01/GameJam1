using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZcoord;
    bool isMoveAble = true;

    private void OnMouseDown()
    {
        if (isMoveAble == true)
        {
            mZcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            //Store offset = gameObject world pos - mouse world pos
            mOffset = gameObject.transform.position - GetMouseWorldPos();
        }
    }

    private void OnMouseUp()
    {
        isMoveAble = false;   
    }

    private Vector3 GetMouseWorldPos()
    {
       
        
            Vector3 mousePoint = Input.mousePosition;

            mousePoint.z = mZcoord;

            return Camera.main.ScreenToWorldPoint(mousePoint);
        
    }
    void OnMouseDrag()
    {
        if (isMoveAble == true)
            //transform.position = new Vector3( (GetMouseWorldPos() + mOffset).x, 0.5f, (GetMouseWorldPos() + mOffset).z);
            transform.position = GetMouseWorldPos() + mOffset;

    }
    private void LateUpdate()
    {
        if (transform.position.y < 0.5f)
        {
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }

    }
}

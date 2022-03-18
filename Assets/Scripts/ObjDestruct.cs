using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestruct : MonoBehaviour
{
    public GameObject Eraser;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Eraser.GetComponent<EraseBtn>().IsEraseClick == true)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null 
                && hit.transform.gameObject.tag == "Obstacle")
            {
                // here you need to insert a check if the object is really a tree
                // for example by tagging all trees with "Tree" and checking hit.transform.tag
                GameObject.Destroy(hit.transform.gameObject);
            }
            
        }
        //if(Eraser.GetComponent<EraseBtn>().IsEraseClick == true)
        //{
         //   Debug.Log("True");
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public static int movespeed = 5;
    public Vector3 userDirection = Vector3.right;

    public void Start()
    {
    }
    public void Update()
    {
        transform.Translate (Vector3.right * movespeed * Time.deltaTime);
    }

    void OnCollisionEnter3D(Collision col)
    {
        if (col.gameObject.tag == "Wall")
        {
            movespeed = -movespeed;
        }
    }
}

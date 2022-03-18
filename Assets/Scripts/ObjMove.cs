using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public Vector3 force;

    private void LateUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(force);
    }
}
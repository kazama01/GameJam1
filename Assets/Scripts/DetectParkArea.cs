using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectParkArea : MonoBehaviour
{
    [Header("Game Manager Object")]
    public GameObject gm;

    [Header("Park")]
    public GameObject correctParkArea;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == correctParkArea.name && other.gameObject.tag == "Parkiran")
        {
            gm = GameObject.Find("GameManager");
            gm.GetComponent<GameManager>().AddScore(50);

            Destroy(this.gameObject);
        }
        else if(other.gameObject.name != correctParkArea.name && other.gameObject.tag == "Parkiran")
        {
            gm = GameObject.Find("GameManager");
            gm.GetComponent<GameManager>().DecreaseHealth();
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObs : MonoBehaviour
{
    public GameObject Obs1;
    public GameObject Obs2;
    public int MaxObs = 2;
    private GameObject[] CurentObs;
    private bool isObsMax; 


    //CODING OBS SPAWN
    public void Obs1Spawn()
    {
        GameObject Clone;
        if (!isObsMax)
        {
            Clone = Instantiate(Obs1, new Vector3(0, 2, 0), Quaternion.identity);
            Clone.transform.rotation = Quaternion.Euler(new Vector3 (0,45,0));
            Clone.GetComponent<ObjDestruct>().Eraser = GameObject.Find("Erase");
            GameObject.Find("Erase").GetComponent<EraseBtn>().IsEraseClick = false;
        }
    }

    public void Obs2Spawn()
    {
        GameObject Clone;
        if (!isObsMax)
        {
            Clone = Instantiate(Obs2, new Vector3(0, 2, 0), Quaternion.identity);
            Clone.transform.rotation = Quaternion.Euler(new Vector3(0, -45, 0));
            Clone.GetComponent<ObjDestruct>().Eraser = GameObject.Find("Erase");
            GameObject.Find("Erase").GetComponent<EraseBtn>().IsEraseClick = false;
        }
    }

    void Update()
    {
        CurentObs = GameObject.FindGameObjectsWithTag("Obstacle");
        
        if (CurentObs.Length < MaxObs)
        {
            isObsMax = false;
        }
        else
        {
            isObsMax = true;
        }

    }
}

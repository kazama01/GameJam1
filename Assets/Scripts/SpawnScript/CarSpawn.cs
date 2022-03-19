using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject UFO1;
    public GameObject UFO2;
    public GameObject UFO3;

    
    int ran;
    public int xPos;
    public int zPos;
    public float delay;
    public float decreaseDelay;
    void Start()
    {
        StartCoroutine(CarDrop());
    }

    IEnumerator CarDrop()
    {
        while (true) 
        {
            xPos = Random.Range(-11, 12);
            zPos = Random.Range(-21, -21);

            if(ran == 0)
            {
                Instantiate(UFO1, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }else if (ran == 1)
            {
                Instantiate(UFO2, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }else if(ran == 2)
            {
                Instantiate(UFO3, new Vector3(xPos, 1, zPos), Quaternion.identity);
            }
            if (delay > 1)
            {
                delay -= decreaseDelay;
            }
            yield return new WaitForSeconds(delay);
        }
       
    }

    private void Update()
    {
       ran = Random.Range(0, 3);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject playerPrefab;

    public int xPos;
    public int zPos;
    public int carCount;

    void Start()
    {
        StartCoroutine(CarDrop());
    }

    IEnumerator CarDrop()
    {
        while (carCount < 6) 
        {
            xPos = Random.Range(-11, 12);
            zPos = Random.Range(-21, -21);
            Instantiate(playerPrefab, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            carCount += 1;
        }
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
    public GameObject ScoreText;

    private void Start()
    {
        ScoreText.GetComponent<Text>().text = "Score : " + GameObject.Find("GameManager").GetComponent<GameManager>().score.ToString();
    }
}

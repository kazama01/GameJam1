using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    [Header("Atribut Pemain")] 
    [SerializeField] private int health;
    public int score;
    public GameObject HPText;
    public GameObject ScoreText;
    private bool scene;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(HPText);
        DontDestroyOnLoad(ScoreText);

    }


    private void Update()
    {
     if(health <= 0 && scene == false)
        {
            SceneManager.LoadScene("GameOver");
            scene = true;
        }
        HPText.GetComponent<Text>().text = "HP " + health + "x";

        ScoreText.GetComponent<Text>().text = "Score : " + score;
    }
    public void DecreaseHealth()
    {
        health--;
    }

    public void AddScore(int scoreIncreasement)
    {
        score += scoreIncreasement;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [Header("Atribut Pemain")] 
    [SerializeField] private int health;
    [SerializeField] private int score;

    private void Update()
    {
     if(health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("ggez");
        }   
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

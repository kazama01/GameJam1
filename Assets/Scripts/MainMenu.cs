using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CreditPanel;

    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CreditButton()
    {
        CreditPanel.SetActive(true);
    }

    public void CloseCredit()
    {
        CreditPanel.SetActive(false);
    }

    public void ExitBtn()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}

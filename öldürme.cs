using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class öldürme : MonoBehaviour
{
    public bool ölü = false;
    public GameObject DeathMenu;
    public Text HighScore;
    public Text score;
    public GameObject OptionsMenu;
    public void öldür()
    {       
            Invoke("öldü", 2);
            Debug.Log("oldu");


        
    }
    public void öldü(int puan)
    {
        DeathMenu.SetActive(true);
        menü(puan);
    }
    public void menü(int puan)
    {

        score.text = "Score: "+puan;
        if (PlayerPrefs.GetInt("yüksekskor") < puan)
        {
            PlayerPrefs.SetInt("yüksekskor", puan);
        }
        HighScore.text = "High Score: "+PlayerPrefs.GetInt("yüksekskor").ToString();
    }
    public void Score()
    {

    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

}

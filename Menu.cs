using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject ButtonPlay;
    public GameObject ButtonQuit;
    public GameObject ButtonOptions;


    public GameObject OptionsMenu;
    public void Baslat()
    {
        SceneManager.LoadScene(1);
    }
    public void cik()
    {
        Application.Quit();
    }
    public void Options()
    {
        ButtonOptions.SetActive(false);
        ButtonPlay.SetActive(false);
        ButtonQuit.SetActive(false);
        OptionsMenu.SetActive(true);
    }
    public void Back()
    {
        OptionsMenu.SetActive(false);
        ButtonOptions.SetActive(true);
        ButtonPlay.SetActive(true);
        ButtonQuit.SetActive(true);

    }
}
   

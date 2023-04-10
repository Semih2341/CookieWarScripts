using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Yeniden()
    {
        SceneManager.LoadScene(1);
    }
    public void anamenü()
    {
        SceneManager.LoadScene(0);
    }
    public void Cık()
    {
        Application.Quit();
    }
}

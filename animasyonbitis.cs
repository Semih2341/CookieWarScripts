using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class animasyonbitis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        Invoke("sahnegecis",9.30f);
    }
    

    public void sahnegecis()
    {
        SceneManager.LoadScene(2);
        Debug.Log("oldu");
    }
    // Update is called once per frame
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Invoke("sil", 2f);
    }
    void sil()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silah : MonoBehaviour
{
    public Transform silahucu;
    public GameObject mermi;
    int deger;
    void Update()
    {   
        if (Input.GetButtonDown("Fire1")||deger==1)
        {
            shoot();
        }   
    }
    void shoot()
    {
        Instantiate(mermi, silahucu.position, silahucu.rotation);
        deger = 0;
    }   
    public void ateş()
    {
        deger = 1;

    }
}

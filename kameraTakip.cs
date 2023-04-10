using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public Transform kamera;
    public Transform oyuncu;
    Vector3 cam = new Vector3(0,0,-10);

    void Start()
    {

    }
    void Update()
    {
        kameratakip();
    }
    void kameratakip()
    {
        cam = oyuncu.position;
        cam.z -= 10;
        cam.y = 0;
        kamera.position = cam;
    }
    

        
        
    
}

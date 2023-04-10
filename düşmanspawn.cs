using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşmanspawn : MonoBehaviour
{
    public GameObject düşmanprefab;
    public Transform nokta;
    public float delaytime;
    public GameObject bombacımülayim;
    public float x;
    Transform oyuncu;
    void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;

        InvokeRepeating("callenemy", x, delaytime);


    }
    void callenemy()
    {
        int Düşmandeger = Random.Range(0, 2);

        if (Vector2.Distance(transform.position, oyuncu.position) < 20)
        {
            if (Düşmandeger == 1)
            {
                Instantiate(bombacımülayim, nokta.position, nokta.rotation);
            }
            else
            {
                Instantiate(düşmanprefab, nokta.position, nokta.rotation);
            }
        }
    }

}

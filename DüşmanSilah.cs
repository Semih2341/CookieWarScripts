using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüşmanSilah : MonoBehaviour
{
    public Transform silahucu;
    public GameObject mermi;
    Transform oyuncu;
    public float delaytime=1f;
    private void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
        Kontrol();
    }
    void Kontrol()
    {
        if (50 > Vector2.Distance(oyuncu.position, transform.position))
        {
            Invoke(nameof(Shoot),delaytime);
        }
    }
    void Shoot()
    {
        Instantiate(mermi, silahucu.position, silahucu.rotation);
        Invoke(nameof(Kontrol), delaytime);

    }
}

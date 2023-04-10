using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public Rigidbody2D rb;
    public float hız = 20f;
    public int hasar = 50;
    public Transform yer;
    public GameObject efekt;
    public Transform oyuncu;

    void Start()
    {
        rb.velocity= transform.right * hız;
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
       if(Mathf.Abs(Vector2.Distance(oyuncu.position,yer.position))>50)
        {
            Instantiate(efekt, transform.position, transform.rotation);
            Destroy(gameObject);
            
            
        }
    }
     void OnTriggerEnter2D(Collider2D nesne)
    {
        Enemy düsman = nesne.GetComponent<Enemy>();
        if (düsman != null)
        {
            düsman.takeDamage(hasar);
        }
        Instantiate(efekt, transform.position, transform.rotation);
        Debug.Log("çarpıyor");
        Destroy(gameObject);
        

    }
}

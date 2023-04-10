using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşman_mermi : MonoBehaviour
{
    public float hız = 20f;
    public int hasar = 50;
    public Transform yer;
    public GameObject efekt;
    Transform oyuncu;
    float ysabiti;
    Vector2 target;
    void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(oyuncu.position.x, transform.position.y);
        if (oyuncu.position.x < transform.position.x)
        {
            target.x -= 10;
        }
        else
        {
            target.x += 10;
        }

    }
    void Update()
    {   
        transform.position = Vector2.MoveTowards(transform.position, target, hız * Time.deltaTime);
        if (Mathf.Abs(Vector2.Distance(yer.position,oyuncu.position))>50|| target.x==transform.position.x)
        {
            Instantiate(efekt, transform.position, transform.rotation);
            Destroy(gameObject);


        }
    }
    void OnTriggerEnter2D(Collider2D nesne)
    {
        PlayerMovement oyuncu = nesne.GetComponent<PlayerMovement>();
        if (oyuncu != null)
        {
            oyuncu.takeDamage(hasar);
        }
        Instantiate(efekt, transform.position, transform.rotation);
        Destroy(gameObject);


    }
}

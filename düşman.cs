using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşman : MonoBehaviour
{
    Transform oyuncu;
    public Animator animator;
    public float speed;
    int RandomDeger;
    private void Start()
    {
        Secim();
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        Vector2 oyuncuMesafe = new Vector2(0, oyuncu.position.y);
        Vector2 Position = new Vector2(0, transform.position.y);
        Vector2 oyuncux = new Vector2(oyuncu.position.x,0);
        Vector2 Positionx = new Vector2(transform.position.x,0);

        /*if (oyuncu.position.x < transform.position.x)
        { 
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }*/
        if (Mathf.Abs(oyuncu.position.x-transform.position.x)>7 || Vector2.Distance(oyuncuMesafe, Position)>0.1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, oyuncu.position, speed * Time.deltaTime);
            animator.SetFloat("Speed", Mathf.Abs(speed));
        }
        else if (Vector2.Distance(transform.position, oyuncu.position) < 7)
        {
            animator.SetFloat("Speed", 0);
        }
        if(RandomDeger == 1)
        {
            if (oyuncu.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-0.60f, 0.60f, 0.60f);
            }
            else
            {
                transform.localScale = new Vector3(0.60f, 0.60f, 0.60f);
            }
            GetComponent<bombaMermi>().enabled = true;
            Destroy(GetComponent<DüşmanSilah>());
        }
           else
        {
            if (oyuncu.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            GetComponent<DüşmanSilah>().enabled = true;
                     Destroy(GetComponent<bombaMermi>());
               }



    }
    void Secim()
    {
        RandomDeger = Random.Range(1, 6);
    }

}

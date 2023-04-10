using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombacımülayim : MonoBehaviour
{
    public float speed;
    Transform oyuncu;
    Vector3 konum = new Vector3(-1, 1, 0);
    public int hasar;
    public GameObject efekt;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            transform.position = Vector2.MoveTowards(transform.position, oyuncu.position, speed * Time.deltaTime);
            animator.SetBool("atlama", false);
        if (oyuncu.position.x < transform.position.x)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }
        
       

         
    }


    void OnTriggerEnter2D(Collider2D nesne)
    {
        PlayerMovement oyuncu = nesne.GetComponent<PlayerMovement>();
        if (oyuncu != null)
        {
            Instantiate(efekt, transform.position+ konum, Quaternion.identity);
            Destroy(gameObject);
            CinemachineShake.Instance.ShakeCamera(12f, .6f);
            oyuncu.takeDamage(hasar);
            Destroy(gameObject);
            Debug.Log("adama çarptı");
        }
        Enemy düsman = nesne.GetComponent<Enemy>();
        if (düsman != null)
        {
            düsman.takeDamage(hasar);
        }




    }

}

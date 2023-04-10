using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merdiven_Çıkma : MonoBehaviour
{ public int merdivenhızı;
    public Joystick joystick;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((collision.tag == "merdiven")&& joystick.Vertical > .5f)
        {

            rb.velocity = new Vector2(0, merdivenhızı);
            Debug.Log("merdivençıktı");
        }
        else if ((collision.tag == "merdiven") && joystick.Vertical <= -.9f)
        {

            rb.velocity = new Vector2(0, -merdivenhızı);
            Debug.Log("merdivenİndi");
        }
        else
        {
            rb.velocity = new Vector2(0, .19f);

        }

    }
}

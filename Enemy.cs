using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{ Vector3 konum = new Vector3(-1,1,0);
    public int can = 100;
    public Text text;
        public GameObject efekt;

    // Update is called once per frame
    public void takeDamage(int damage)
    {
        can -= damage;
        if (can <= 0)
        {
            death();
        }
    }
    public void death()
    {
        
        Instantiate(efekt, transform.position + konum, Quaternion.identity);
        Destroy(gameObject);
        
        CinemachineShake.Instance.ShakeCamera(5f, .3f);
        FindObjectOfType<PlayerMovement>().score();


    }
}

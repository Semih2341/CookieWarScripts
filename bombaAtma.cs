using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaAtma : MonoBehaviour
{ public int hasar;
    public GameObject efekt;
    public Rigidbody2D rb;
    public float mesafe = 100f;
    int minBomba=200;
    int maxBomba=500;
    private void Start()
    {
        Transform oyuncu = GameObject.FindGameObjectWithTag("Player").transform;
        if (transform.position.x < oyuncu.position.x)
        {
            int power = Random.Range(minBomba, maxBomba);
            Bombthrow(power);
        }
        else
        {   
            int power = Random.Range(minBomba * -1, maxBomba * -1);
            Bombthrow(power);
        }
    }
    void Bombthrow(int power)
    {
        
        rb.AddForce(new Vector2(power, 300f));
    }
    void OnTriggerEnter2D(Collider2D nesne)
    {
        PlayerMovement oyuncu = nesne.GetComponent<PlayerMovement>();
        if (oyuncu != null)
        {
            oyuncu.takeDamage(hasar);
            Debug.Log("adama çarptý");
        }
        Instantiate(efekt, transform.position , Quaternion.identity);
        Debug.Log("yere çarptý");
        CinemachineShake.Instance.ShakeCamera(3f, .3f);
        Destroy(gameObject);


    }
}
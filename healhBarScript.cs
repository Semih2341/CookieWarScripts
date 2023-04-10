using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healhBarScript : MonoBehaviour
{
   
    public void canbarý(float candeger)
        
    {
        float deger = candeger / 25.3164f;
        Vector3 vector3 = new Vector3(deger, 0.4f, 1f);
        transform.localScale=vector3;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flightplayermovment : MonoBehaviour
{
    public Rigidbody missilerig;
    public float missilevel;
    void Update()
    {
        missilerig.velocity = transform.forward * missilevel;
      
    }
    
    
}

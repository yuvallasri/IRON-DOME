using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp : MonoBehaviour
{
    public GameObject expeffect;

    public void Update()
    {



    }
    private void OnTriggerEnter(Collider other)
    {
       
            Instantiate(expeffect, transform.position, transform.rotation);
            Destroy(gameObject);
        
       
    }
}

    

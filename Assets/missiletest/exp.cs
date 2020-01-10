using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp : MonoBehaviour
{
    public GameObject expeffect;
    bool hasexplo = false;

    public void Update()
    {



    }
    private void OnTriggerEnter(Collider other)
    {
        if (hasexplo == false)
        {
            Instantiate(expeffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       
    }
}

    

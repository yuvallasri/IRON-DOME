using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exp1 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
       // gameObject.transform.position = new Vector3(Random.Range(0,100), Random.Range(0, 100), Random.Range(0, 100));
        Destroy(gameObject);
    }
    
      
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRocket : MonoBehaviour
{
   
   
    public GameObject rocket;
       void Update()
    { 


        if (Input.GetKeyUp(KeyCode.Mouse0))

        {

            Instantiate(rocket, transform.position,transform.rotation);

        }
    }
 
}

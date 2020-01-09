using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class myRocket : MonoBehaviour
{
   
   
    public GameObject rocket;
    GameObject rocketclone;
       void Update()
    { 


        if (Input.GetKeyUp(KeyCode.Mouse0))

        {

            rocketclone = Instantiate(rocket, transform.position, Quaternion.identity) as GameObject;
            Destroy(rocketclone, 10);

        }
    }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class myRocket : MonoBehaviour
{
    public AudioClip impact;
    AudioSource bom;
   
    public GameObject rocket;
    GameObject rocketclone;
    private void Start()
    {

        bom = GetComponent<AudioSource>();

    }
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Mouse0))

        {

            rocketclone = Instantiate(rocket, transform.position, Quaternion.identity) as GameObject;
            bom.PlayOneShot(impact, 1.0f);
            Destroy(rocketclone, 4);

        }
    }
    private void OnDestroy()
    {
        
    }

}

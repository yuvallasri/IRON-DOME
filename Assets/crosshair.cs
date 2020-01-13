using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{

    public GameObject cross;
    public GameObject red;
    public GameObject gray;
    public GameObject target;
    
    public void Start()
    {
       
        gray.gameObject.SetActive(true);
        red.gameObject.SetActive(false);


    }


    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(cross.transform.position, cross.transform.forward);
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);


            if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag.Equals("target"))
            {
                
                red.gameObject.SetActive(true);
                gray.gameObject.SetActive(false);
            }
        }

        else
        {
            red.gameObject.SetActive(false);
            gray.gameObject.SetActive(true);
        }
    }
    
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crosshair : MonoBehaviour
{

    public GameObject cross;
    public GameObject red;
    public GameObject gray;


    private SpriteRenderer graySpriteRenderer;
    private SpriteRenderer redSpriteRenderer;

    public void Start()
    {

        graySpriteRenderer = gray.GetComponent<SpriteRenderer>();
        redSpriteRenderer = red.GetComponent<SpriteRenderer>();
        //gray.gameObject.SetActive(true);
        //red.gameObject.SetActive(false);
        graySpriteRenderer.enabled = true;
        redSpriteRenderer.enabled = false;

    }


    void FixedUpdate()
    {
        RaycastHit hit;
        //Ray ray = new Ray(cross.transform.position, cross.transform.forward);
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity);
        if (hit.collider)
        {
            Debug.DrawLine(transform.position, hit.collider.transform.position, Color.red);
            if (hit.collider.tag == "target")
            {
                graySpriteRenderer.enabled = false;
                redSpriteRenderer.enabled = true;
            }
        }
        else
        {
            graySpriteRenderer.enabled = true;
            redSpriteRenderer.enabled = false;
        }

        //if (Physics.Raycast(ray, out hit))
        //{
        //    if (hit.collider.tag.Equals("target"))
        //    {

        //        red.gameObject.SetActive(true);
        //        gray.gameObject.SetActive(false);
        //    }
        //}

        //else
        //{
        //    red.gameObject.SetActive(false);
        //    gray.gameObject.SetActive(true);
        //}
    }

}
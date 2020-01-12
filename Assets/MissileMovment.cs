using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovment : MonoBehaviour
{
    private Transform rockettarget;
    public Rigidbody missilerig;
    public float turn;
    public float missilevel;
    public GameObject explosioneffect;
    void Update()
    {
        missilerig.velocity = transform.forward * missilevel;
        if (GameObject.FindGameObjectsWithTag("target").Length > 0)
        {
            rockettarget = GameObject.FindWithTag("target").transform;
            var missiletargetrotation = Quaternion.LookRotation(rockettarget.position - transform.position);
            missilerig.MoveRotation(Quaternion.RotateTowards(transform.rotation, missiletargetrotation, turn));
        }


        DestroyGameObject();
    }
    void DestroyGameObject()
    {

        Destroy(gameObject, 2f);
    }
    public void OnTriggerEnter(Collider other)
    {
        DestroyGameObject();
    }

    void OnDestroy()
    {
        Instantiate(explosioneffect, transform.position, transform.rotation);
    }
}

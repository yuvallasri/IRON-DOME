using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anemymissilemovment : MonoBehaviour
{
    public GameObject anemymissile;
    private Transform rockettarget;
    public Rigidbody missilerig;
    public float turn;
    public float missilevel;
    public GameObject explosioneffect;

    void Update()
    {
         
        missilerig.velocity = transform.forward * missilevel;
        rockettarget = GameObject.FindWithTag("home").transform;
        var missiletargetrotation = Quaternion.LookRotation(rockettarget.position - transform.position);
        missilerig.MoveRotation(Quaternion.RotateTowards(transform.rotation, missiletargetrotation, turn));

    }
    void DestroyGameObject()
    {
        var mewposition = new Vector3(Random.Range(-150, 150), 500, 12);

        Instantiate(anemymissile, mewposition, this.transform.rotation);
        Instantiate(explosioneffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
    public void OnTriggerEnter(Collider other)
    {
               DestroyGameObject();
    }

    void OnDestroy()
    {
        

    }
}

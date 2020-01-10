using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missiletest : MonoBehaviour
{
    public Transform rockettarget;
    public Rigidbody missilerig;
    public float turn;
    public float missilevel;
    void Update()
    {

            missilerig.velocity = transform.forward * missilevel;
            var missiletargetrotation = Quaternion.LookRotation(rockettarget.position - transform.position);
            missilerig.MoveRotation(Quaternion.RotateTowards(transform.rotation,missiletargetrotation,turn));

    }
   

}

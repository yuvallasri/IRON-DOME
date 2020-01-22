using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMovment : MonoBehaviour
{
    private GameObject cross;
    private Transform rockettarget;
    public float turn;
    public float missilevel;
    public GameObject explosioneffect;
    private Rigidbody missileRigidBody;

    void Start()
    {
        missileRigidBody = GetComponent<Rigidbody>();
        cross = GameObject.Find("cross");
    }
    void Update()
    {
        missileRigidBody.velocity = transform.forward * missilevel;
        RaycastHit hit;
        Physics.Raycast(cross.transform.position, cross.transform.forward, out hit, Mathf.Infinity);
        Debug.Log(hit.transform.position);
        Debug.DrawRay(transform.position, transform.forward);

        if (hit.collider && hit.collider.tag == "target")
        {
            Debug.Log("inside");
            rockettarget = hit.transform;
            var missiletargetrotation = Quaternion.LookRotation(rockettarget.position - transform.position);
            missileRigidBody.MoveRotation(Quaternion.RotateTowards(transform.rotation, missiletargetrotation, turn));

        }

        DestroyGameObject();

    }

    void DestroyGameObject()
    {
        Destroy(gameObject, 5f);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatingenamys : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        Invoke("CreateMyInstance", 3.0f);
    }

    // Will be called 3 seconds after level start
    void CreateMyInstance()
    {
        Instantiate(prefab, this.transform.position,this.transform.rotation);
    }
}
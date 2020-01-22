using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class YOUWIN : MonoBehaviour
{
    public GameObject target;
    private void Update()
    {
        target = GameObject.FindWithTag("target");
        if (GameObject.FindGameObjectsWithTag("target").Length < 1)
        {
            SceneManager.LoadScene(5);

        }
    }

}

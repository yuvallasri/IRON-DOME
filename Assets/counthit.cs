using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class counthit : MonoBehaviour
{
    int x = 0;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject life4;
    public GameObject life5;

    private void OnTriggerEnter(Collider other)
    {
        if(x==0)
            Destroy(life1);
        if (x == 1)
            Destroy(life2);
        if (x == 2)
            Destroy(life3);
        if (x == 3)
            Destroy(life4);
        if (x == 5)
                 SceneManager.LoadScene(2);
        x++;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class counthiflight : MonoBehaviour
{
    int x = 0;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    

    private void OnTriggerEnter(Collider other)
    {
        if(x==0)
            Destroy(life1);
        if (x == 1)
            Destroy(life2);
        if (x == 2)
            Destroy(life3);
        if (x == 3)
                 SceneManager.LoadScene(3);
        x++;

    }

}

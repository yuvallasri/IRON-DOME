using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class stopwatch : MonoBehaviour
{
    public float timeLeft = 40.0f;
    public Text startText; 


    void Update()
    {
        timeLeft -= Time.deltaTime;
        startText.text = (timeLeft).ToString("0");
        
    }
}

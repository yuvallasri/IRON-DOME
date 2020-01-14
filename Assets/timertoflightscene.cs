using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timertoflightscene : MonoBehaviour
{
        [SerializeField]
        private float delay = 20f;
        private float timepass;
        void Update(){
        timepass += Time.deltaTime;
        if (timepass>delay)
        {
            SceneManager.LoadScene(3);
        }
        
    }
}

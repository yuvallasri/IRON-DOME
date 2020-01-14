using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show_cursor : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

}

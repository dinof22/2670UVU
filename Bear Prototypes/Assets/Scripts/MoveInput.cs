using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public static Action<float> KeyAction;

    public static Action JumpAction;
    public static Action Grab;
    public static Action offGrab;
    public static Action constantAction;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }


        if (KeyAction != null)
        {
            KeyAction(Input.GetAxis("Horizontal"));
        }




        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (Grab != null)
            {
                Grab();
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            if (offGrab != null)
            {
                offGrab();
            }
        }






        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.localScale = new Vector3(1f, 0.5f, 1f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);
        }


        if (constantAction != null)
        {
            constantAction();
        }

    }
}

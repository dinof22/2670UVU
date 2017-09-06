using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public static Action<float> KeyAction;

    public static Action JumpAction;
    public static Action GrabAction;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public static Action<float> KeyAction;

    public static Action JumpAction;
    public static Action GrabAction;


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
    }
}

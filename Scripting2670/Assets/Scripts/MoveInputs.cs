using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInputs : MonoBehaviour
{

    public static Action<float> KeyAction;

    public static Action JumpAction;


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

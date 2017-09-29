using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BearMoveInputs : MonoBehaviour {


    public static Action<float> BearKeyAction;

    public static Action BearJumpAction;
    public static Action BearConstantAction;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            BearJumpAction();
        }


        if (BearKeyAction != null)
        {
            BearKeyAction(Input.GetAxis("Horizontal2"));
        }


        if (BearConstantAction != null)
        {
            BearConstantAction();
        }

    }
}

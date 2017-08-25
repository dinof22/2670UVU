using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInputs : MonoBehaviour
{


    Action KeyAction;

    void Start()
    {
        KeyAction = Move;
    }

    void Move()
    {
        print("left arrow");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            KeyAction();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveCharacter : MonoBehaviour {


    CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveInputs.KeyAction = Move;
    }

    void Move(float _movement)
    {
        print(_movement);
    }
}

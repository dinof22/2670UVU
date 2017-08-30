using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveCharacter : MonoBehaviour {


    CharacterController cc;

    Vector3 tempMove;

    public float speed = 5;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveInputs.KeyAction += Move;
    }

    void Move(float _movement)
    {
        tempMove.x = _movement * speed * Time.deltaTime;
        cc.Move(tempMove);
    }
}

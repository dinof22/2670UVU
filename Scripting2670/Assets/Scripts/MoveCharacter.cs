using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveCharacter : MonoBehaviour {


    CharacterController cc;

    Vector3 tempMove;

    public float speed = 5;
    public float gravity = 1;
    private float jumpHeight = 0.2f;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        PlayButton.Play += Onplay;
    }



    void Onplay()
    {
        MoveInputs.JumpAction = Jump;
        MoveInputs.KeyAction += Move;
        PlayButton.Play -= Onplay;
        
    }


    void Jump()
    {
        print("Jump");
        tempMove.y += jumpHeight;
    }


    void Move(float _movement)
    {
        tempMove.y -= gravity * Time.deltaTime;
        tempMove.x = _movement * speed * Time.deltaTime;
        print("move");
        cc.Move(tempMove);
    }
}

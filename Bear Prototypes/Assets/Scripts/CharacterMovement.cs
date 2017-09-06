using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour {

    CharacterController cc;

    Vector3 tempMove;

    public float speed;
    public float gravity;
    public float jumpHeight;
    private bool doubleJump;


    private Action onLandAction;





    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveInput.JumpAction += Jump;
        MoveInput.KeyAction += Move;
        doubleJump = false;
    }





    void Jump()
    {
        
        if (cc.isGrounded)
        {
            print("Jump");
            tempMove.y = jumpHeight;
            doubleJump = true;
        }
        else
        {
            if (doubleJump)
            {
                print("Jump");
                tempMove.y = jumpHeight;
                doubleJump = false;
            }           
        }
    }


    void Move(float _movement)
    {
        
        tempMove.x = _movement * speed;
        cc.Move(tempMove * Time.deltaTime);
        if (!cc.isGrounded)
        {
            tempMove.y -= gravity * Time.deltaTime;
            if (onLandAction == null)
            {
                onLandAction += resetGravity;
            }
        }
        if (cc.isGrounded)
        {
            if (onLandAction != null)
            {
                onLandAction();
                onLandAction = null;
            }
        }


    }


    void resetGravity()
    {
        tempMove.y = -.1f;
    }
}

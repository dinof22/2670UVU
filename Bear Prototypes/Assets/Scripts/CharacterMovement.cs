using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharacterMovement : MonoBehaviour {

    CharacterController cc;

    Vector3 tempMove;

    public float speed;
    public float gravity = 40f;
    public float jumpHeight;
    [HideInInspector] public bool doubleJump;
    public bool inWater;
    public static bool RidingBear = false;

    private Action onLandAction;
    public static Action PlayerGroundedAction;


    public Transform respawnPoint;

    private bool gameIsPaused = false;





    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveInput.JumpAction += Jump;
        MoveInput.KeyAction += Move;
        newGrapScript.KeepGravity += KeepGravityHandler;
        doubleJump = false;
        inWater = false;   

    }

    private void KeepGravityHandler()
    {
        if (inWater)
        {
            gravity = 5f;
        }
        if (inWater == false)
        {
            gravity = 40f;
        }
    }

    void Jump()
    {

        if (cc.isGrounded)
        {
            //print("Jump");
            tempMove.y = jumpHeight;
            doubleJump = true;
            PlayerGroundedAction();

        }
        else
        {
            if (doubleJump)
            {
                if (inWater)
                {
                    //print("waterJump!!");
                    tempMove.y = jumpHeight;
                    doubleJump = true;
                }
                else {
                    //print("Jump");
                    tempMove.y = jumpHeight;
                    doubleJump = false;
                }
            }
        }
    }


    void Move(float _movement)
    {

        tempMove.x = _movement * speed;
        cc.Move(tempMove * Time.deltaTime);
        if (RidingBear)
        {
            cc.Move(BearMovement.tempMove * Time.deltaTime);
        }
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


    [HideInInspector] public void resetGravity()
    {
        tempMove.y = -.1f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    CharacterController cc;

    Vector3 tempMove;

    public float speed;
    public float gravity;
    public float jumpHeight ;
    private bool doubleJump;





    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveInput.JumpAction += Jump;
        MoveInput.KeyAction = MoveInput.KeyAction + Move;
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
        tempMove.y -= gravity * Time.deltaTime;
        tempMove.x = _movement * speed * Time.deltaTime;
        print("move");
        cc.Move(tempMove);
    }
}

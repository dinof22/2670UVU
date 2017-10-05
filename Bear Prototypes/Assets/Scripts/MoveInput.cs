using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveInput : MonoBehaviour {

    public static Action<float> KeyAction;


    public static Action JumpAction;
    public static Action Grab;
    public static Action offGrab;
    public static Action constantAction;
    public static Action CenterPlayers;


    public static Action<bool> RotateClockwise;
    public static Action<bool> RotateCounterClockwise;


  


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





        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (Grab != null)
            {
                Grab();
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            if (offGrab != null)
            {
                offGrab();
            }
        }



        if (RotateClockwise != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                RotateClockwise(true);
            }

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                RotateClockwise(false);
            }
        }


        if (RotateCounterClockwise != null)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                RotateCounterClockwise(true);
            }
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                RotateCounterClockwise(false);
            }
        }






        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.localScale = new Vector3(1f, 0.5f, 1f);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);
        }


        if (constantAction != null)
        {
            constantAction();
        }


        if (Input.GetKeyDown(KeyCode.R))
        {
            print("resetting bear and player z axis");
        }

       

    }







}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class grabbableScript : MonoBehaviour {

    public GameObject SolidCube;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("you touched teh box");
            //SolidCube.transform.position = new Vector3(44, 55, 0);    //this WORKS
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                print("grabbing!!!");
                //transform.root = cc.gameObject.transform;
            }
        }
    }
}

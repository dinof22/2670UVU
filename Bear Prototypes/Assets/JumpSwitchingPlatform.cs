using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class JumpSwitchingPlatform : MonoBehaviour {


    public bool infront;
    Vector3 Movement;


	void Start () {
        MoveInput.JumpAction += JumpActionHanlder;
	}

    private void JumpActionHanlder()
    {
        StartCoroutine(MoveToFront());
        if (infront)
        {
            infront = false;
            StopCoroutine(MoveToFront());
            StartCoroutine(MoveToBack());
            
        }
    }


    IEnumerator MoveToBack()
    {
        while (transform.position.z < 9)
        {
            Movement.z = 3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }
    IEnumerator MoveToFront()
    {
        while (transform.position.z > -16)
        {
            Movement.z = -3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }


}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnmateCharacter : MonoBehaviour {

    Animator anims;


	void Start () {
        anims = GetComponent<Animator>();

        PlayButton.Play += Onplay;
        
	}



    void Onplay()
    {
        MoveInputs.KeyAction += Animate;
        PlayButton.Play -= Onplay;
    }



    private void Animate(float obj)
    {
        anims.SetFloat("Walk", obj);
    }
}

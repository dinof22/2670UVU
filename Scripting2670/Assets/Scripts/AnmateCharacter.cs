using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnmateCharacter : MonoBehaviour {

    Animator anims;

	// Use this for initialization
	void Start () {
        anims = GetComponent<Animator>();
        MoveInputs.KeyAction += Animate;
	}

    private void Animate(float obj)
    {
        anims.SetFloat("Walk", obj);
    }
}

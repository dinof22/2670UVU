using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterScript : MonoBehaviour {

    public GameObject player;

    CharacterMovement cc;

    private float fakeGravity;

    private void Start()
    {
        cc = player.gameObject.GetComponent<CharacterMovement>();
        //print(cc.gravity);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cc.gravity = 5f;
            cc.inWater = true;
            cc.doubleJump = true;
            cc.speed = 5;
            cc.jumpHeight = 3;
            cc.resetGravity();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            cc.inWater = false;
            cc.gravity = 40f;
            cc.speed = 8f;
            cc.jumpHeight = 15f;
            cc.doubleJump = true;
        }
    }
}

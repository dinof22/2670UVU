using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeybarScript : MonoBehaviour {

    public GameObject player;

    CharacterMovement cc;

    private float fakeGravity;

    private void Start()
    {
        cc = player.gameObject.GetComponent<CharacterMovement>();
        //print(cc.gravity);
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                print("controlPressed");
               cc.gravity = 0f;
            }
            if (Input.GetKeyUp(KeyCode.LeftControl))
            {
                print("left control released!!");
                cc.gravity = 40f;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cc.gravity = 40f;
        }
    }
}

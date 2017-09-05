using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabTrigger : MonoBehaviour {


    public GameObject grabHolder;
    CharacterController cc;

    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }



    private void grab()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            print("control Pressed");
            //GetComponent<Rigidbody>().useGravity = false;
            //this.transform.position = new Vector3(grabHolder.transform.position.x, grabHolder.transform.position.y, 0f);
            //this.transform.eulerAngles = new Vector3(0, 0, 0);
            this.transform.parent.parent = grabHolder.transform;

        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            print("control let go");
            this.transform.parent.parent = null;
            //GetComponent<Rigidbody>().useGravity = true;
        }


        if (!cc.isGrounded)
        {
            GetComponent<Rigidbody>().useGravity = false;
        }
        if (cc.isGrounded)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            grab();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("control let go");
            this.transform.parent.parent = null;
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrigger : MonoBehaviour {

    public GameObject Bear;

    private void Start()
    {
        Bear.GetComponent<BackAndForthScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("RRRAWWWWRRRR");
        Bear.GetComponent<BackAndForthScript>().enabled = true;
        Bear.GetComponent<BackAndForthScript>().speed = 7.5f;
        Bear.transform.position = new Vector3(371f, -34.9f, -2.95f);
    }
}

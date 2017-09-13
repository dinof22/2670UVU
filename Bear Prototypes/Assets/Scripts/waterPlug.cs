using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterPlug : MonoBehaviour {

    public GameObject waterPool1;
    public GameObject waterPool2;

    private void OnTriggerExit(Collider other)
    {
        //if (other.tag == "Plug")
       //{
            print("unplugged!!");
            waterPool1.transform.position = new Vector3(waterPool1.transform.position.x, waterPool1.transform.position.y - 5, waterPool1.transform.position.z);
            waterPool2.transform.position = new Vector3(waterPool2.transform.position.x, waterPool2.transform.position.y + 5, waterPool2.transform.position.z);
        //}
        this.gameObject.SetActive(false);
    }
}

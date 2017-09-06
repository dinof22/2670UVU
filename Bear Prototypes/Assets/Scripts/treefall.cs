using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treefall : MonoBehaviour {


    public GameObject tree2, tree3, tree4, tree5, tree6;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("circleDestroyer"))
        { 
        print("tree has been hit!!!");
        this.GetComponent<Rigidbody>().useGravity = true;

        }
        if (collision.gameObject.CompareTag("cubeDestroyer"))
        {
            print("bruh");
            this.transform.DetachChildren();
            tree2.AddComponent<Rigidbody>();
            tree3.AddComponent<Rigidbody>();
            tree4.AddComponent<Rigidbody>();
            tree5.AddComponent<Rigidbody>();
            tree6.AddComponent<Rigidbody>();

        }
    }
}

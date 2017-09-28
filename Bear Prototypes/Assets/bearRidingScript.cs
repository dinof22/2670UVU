using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearRidingScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (true)
        {
            other.transform.parent = this.transform.parent;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}

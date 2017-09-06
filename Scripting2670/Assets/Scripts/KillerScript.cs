using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KillerScript : MonoBehaviour {

    public static Action End;

    private void OnTriggerEnter()
    {
        End();
    }
}

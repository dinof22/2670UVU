using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{


    public Transform startPoint;

    public GameObject art;

    void Start()
    {
        KillerScript.End += ResetThis;
    }

    private void ResetThis()
    {
        transform.position = startPoint.position;
    }

}



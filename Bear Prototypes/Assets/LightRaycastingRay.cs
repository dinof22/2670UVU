using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LightRaycastingRay : MonoBehaviour {


    public static Action turnOffLight;


    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            //Debug.Log(hit.transform.name);
            turnOffLight();


            TurnOnLightScript target = hit.transform.GetComponent<TurnOnLightScript>();


            if (target != null)
            {
                target.TurnOnLights();
            }


        }

    }
}

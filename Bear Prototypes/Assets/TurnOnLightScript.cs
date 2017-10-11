using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TurnOnLightScript : MonoBehaviour {

    //private Transform ThisThingsChild;

    private void Start()
    {
        LightRaycastingRay.turnOffLight += TurnOffLightHandler;
    }

    public void TurnOnLights()
    {
        //print(this.transform.GetChild(0).name);
        this.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void TurnOffLightHandler()
    {
        this.transform.GetChild(0).gameObject.SetActive(false);
    }

}

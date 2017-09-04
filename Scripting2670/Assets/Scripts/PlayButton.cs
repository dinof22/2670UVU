using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour {


    public static Action Play;
    public GameObject thePlayButton;

    public void PushPlay()
    {
        Play();
        //Invoke("TurnOffButton", 0.5f);
        TurnOffButton();
    }



    void TurnOffButton()
    {
        GetComponent<Button>().interactable = false;
        thePlayButton.SetActive(false);
    }
}

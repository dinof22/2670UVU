using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetData : MonoBehaviour {


    void Start()
    {

    }

    void OnApplicationQuit()
    {
        GameData.SetData();
    }
}

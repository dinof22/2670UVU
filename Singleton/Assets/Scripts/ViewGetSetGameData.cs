using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGetSetGameData : MonoBehaviour {
    public GameData myGameData;

    void Awake()
    {
        GetData();
    }

    void Update()
    {
        SetData();
    }

    [ContextMenu("Get Data")]
    void GetData()
    {
        GameData.GetData();
        myGameData = GameData.Instance;
        print(myGameData);
    }


    [ContextMenu("Set Data")]
    void SetData()
    {
        myGameData.SaveDataFromInstance();
        print(PlayerPrefs.GetString(GameData.dataName));
    }
}

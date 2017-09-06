using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetScript : MonoBehaviour {

    public void resetScene()
    {
        SceneManager.LoadScene("Prototype One");
    }
}

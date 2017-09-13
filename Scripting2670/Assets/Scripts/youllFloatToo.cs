using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youllFloatToo : MonoBehaviour {

    public Vector3 moveIt;

    IEnumerator floatTheBallooon()
    {
        while (moveIt.x < 0.3f)
        {
            print("youll float too");
            moveIt.x += 0.003f * Time.deltaTime;
            transform.Translate(moveIt);
            yield return null;
        }
    }

	void Start () {
        StartCoroutine(floatTheBallooon());
	}




}

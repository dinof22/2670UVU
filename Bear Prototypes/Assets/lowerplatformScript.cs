﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowerplatformScript : MonoBehaviour {

    Vector3 Movement;

    void Start()
    {
        StatuePuzzleManager.ActionPuzzleComplete += ActionPuzzleCompleteHandler;
    }

    private void ActionPuzzleCompleteHandler()
    {
        StartCoroutine(MovePlatformDown());
    }

    IEnumerator MovePlatformDown()
    {
        while (transform.position.y > -147)
        {
            Movement.y = -3f * Time.deltaTime;
            transform.Translate(Movement);
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForthScript : MonoBehaviour {


    public float min = 43f;
    public float max = 59f;
    public float speed;


    void Start()
    {

        min = transform.position.x;
        max = transform.position.x + 16;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * speed, max - min) + min, transform.position.y, transform.position.z);
    }


}

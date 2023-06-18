using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sentry;
using System;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate () 
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        GetComponent<Rigidbody>().AddForce(move);

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }

        if (Input.GetKeyDown("return"))
        {
            print("Enter Pressed");
            throw new Exception("Test Error");
        }
    }
}

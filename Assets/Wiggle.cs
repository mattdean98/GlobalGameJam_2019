﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    // User Inputs
    public float degreesPerSecond = 10.0f;
    public float frequency = 1f;

    // Position Storage Variables
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    // Use this for initialization
    void Start()
    {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        

    }
}

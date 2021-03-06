﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int WalkingDistance;
    public GameObject _Player;
    private Rigidbody rb;
    public float speed;
    public Text Text;

    private int _points;

    // Start is called before the first frame update
    void Start()
    {
        //set to 0
        _points = 0;
        //WalkingDistance = 10;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    void OnTriggerEnter(Collider other)
    {
        //increase points
        ++_points;
        //Text.
        if (other.gameObject.CompareTag("Pick Up")){
            Destroy(other.gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        /* 
        //walk
        if (Input.GetKeyDown(KeyCode.W))
        {
            _Player.transform.Translate(0f, 1f * WalkingDistance, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _Player.transform.Translate(-1f * WalkingDistance, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _Player.transform.Translate(0f, -1f * WalkingDistance, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _Player.transform.Translate(1f * WalkingDistance, 0f, 0f);
        }

        //run
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            _Player.transform.Translate(0f, 2f * WalkingDistance, 0f);
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            _Player.transform.Translate(-2f * WalkingDistance, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            _Player.transform.Translate(0f, -2f * WalkingDistance, 0f);
        }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            _Player.transform.Translate(2f * WalkingDistance, 0f, 0f);
        }
    */
        
    }
}

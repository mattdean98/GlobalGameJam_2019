using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int WalkingDistance;
    public GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {
        //WalkingDistance = 10;
    }

    void FixedUpdate() {
        
    }
    // Update is called once per frame
    void Update()
    {
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
    }
}

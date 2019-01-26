using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : MonoBehaviour
{

    public GameObject Item;
    public GameObject OtherObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided with: " + collision.collider.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("left collision!");
    }
}

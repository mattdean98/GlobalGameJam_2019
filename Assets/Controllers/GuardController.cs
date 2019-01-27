using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Pinger;
    public Camera Vision;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Renderer>().IsVisibleFrom(Vision))
        {
            if (IsNotBlocked(Pinger, Player))
            {
                Debug.Log("Visible");
            }
        }
    }

    public bool IsNotBlocked(GameObject gm1, GameObject gm2)
    {
        //if (Physics.Linecast(gm1.transform.position, gm2.transform.position))
        //{
        //    return false;
        //}

        float maxRange = 5;
        RaycastHit hit;

        if (Physics.Raycast(transform.position, (gm1.transform.position - gm2.transform.position), out hit, maxRange))
        {
            if (hit.transform == gm2)
            {
                // In Range and i can see you!
                Debug.Log("visible");
            }
        }

        return true;
    }
    
}
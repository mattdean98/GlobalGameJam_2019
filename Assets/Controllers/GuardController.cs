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
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        Player.layer = 2;
        Pinger.layer = 2;

        //if (Physics.Raycast(transform.position, fwd, 2, ))
        //{
        //    Debug.Log("There is something in front of the object!");
        //}

        if (!Physics.Linecast(Pinger.transform.position, Player.transform.position))
        {
            //check if in range of flashlight
            var between = Player.transform.position - Pinger.transform.position;
            var guardForward = Pinger.transform.forward;

            //compare angle
            float angle = Vector3.Angle(guardForward, between);
            if (angle < 40f)
            {
                Debug.Log(angle);
            }
        }

        Player.layer = 8;
        Pinger.layer = 8;



        //Vision.enabled = true;
        //if (Player.GetComponent<Renderer>().IsVisibleFrom(Vision))
        //{
        //    if (IsNotBlocked(Pinger, Player))
        //    {
        //        Debug.Log("Visible");
        //    }
        //}
        //Vision.enabled = false;
    }

    //public bool IsNotBlocked(GameObject gm1, GameObject gm2)
    //{
    //    //if (Physics.Linecast(gm1.transform.position, gm2.transform.position))
    //    //{
    //    //    return false;
    //    //}

    //    gm1.layer = 2;
    //    gm2.layer = 2;

    //    float maxRange = 5;
    //    RaycastHit hit;

    //    if (Physics.Raycast(transform.position, (gm1.transform.position - gm2.transform.position), out hit, maxRange))
    //    {
    //        if (hit.transform == gm2)
    //        {
    //            // In Range and i can see you!
    //            Debug.Log("visible");
    //        }
    //    }

    //    gm1.layer = 0;
    //    gm2.layer = 0;

    //    return true;
    //}
    
}
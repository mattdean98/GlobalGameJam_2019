using UnityEngine;

public class GuardController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Guard;
    public GameObject Pinger;
    public Camera Vision;

    public GameObject Light;

    public GameObject IsCaught;

    void FixedUpdate()
    {
        Player.layer = 2;
        Pinger.layer = 2;

        if (!Physics.Linecast(Pinger.transform.position, Player.transform.position))
        {
            var between = Player.transform.position - Pinger.transform.position;
            var guardForward = Pinger.transform.forward;

            float angle = Vector3.Angle(guardForward, between);
            if (angle < 40f)
            {
                Debug.Log("Visible!");
                IsCaught.SetActive(true);

                Light.GetComponent<Wiggle>().enabled = false;
            }
        }

        Player.layer = 8;
        Pinger.layer = 8;
    }
}
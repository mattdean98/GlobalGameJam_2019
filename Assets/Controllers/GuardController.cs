using System.Collections;
using UnityEngine;

public class GuardController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Guard;
    public GameObject Pinger;
    public Camera Vision;
    public AudioSource Whistle;

    public GameObject CaughtText;

    public GameObject Light;

    public GameObject IsCaught;

    private int _seenCount;

    private PauseController pauseController;

    private void Start()
    {
        CaughtText.SetActive(false);
        _seenCount = 0;
        ;
        pauseController = new PauseController();
    }

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
                //Debug.Log("Visible at count = " + _seenCount);
                if (_seenCount > 5)
                {
                    CaughtText.SetActive(true);

                    if (IsCaught.activeSelf == false)
                    {
                        Whistle.Play();
                    }
                    IsCaught.SetActive(true);
                    Light.GetComponent<Wiggle>().enabled = false;
                    _seenCount = 0;

                    StartCoroutine(Reload());
                }

                _seenCount++;
            }
        }
        else
        {
            _seenCount = 0;
        }

        Player.layer = 8;
        Pinger.layer = 8;
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(1.5f);
        pauseController.Reload();
    }
}
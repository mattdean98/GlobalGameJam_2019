using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    public GameObject FinishedText;
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
        if(collision.gameObject.tag == "Player")
        {
            FinishedText.SetActive(true);

            //end game
            StartCoroutine(EndGameCall(1));
        }
    }


    IEnumerator EndGameCall(int n)
    {
        yield return new WaitForSeconds(n);

        Application.Quit();
    }
}

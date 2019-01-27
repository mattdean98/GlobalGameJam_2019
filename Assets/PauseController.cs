using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    SceneManager scene = new SceneManager();
    GameObject[] pauseObjects;

    void Start() {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused();
	}

	// Update is called once per frame
	void Update() {
        //Debug.Log ("Is this even being updated");
		//uses the p button to pause and unpause the game
		if(Input.GetKeyDown(KeyCode.Escape))
		{
            //Debug.Log ("I saw the light!");
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				//Debug.Log ("high");
				Time.timeScale = 1;
				hidePaused();
			}
		}
	}

	//Reloads the Level
	public void Reload(){
		//Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene("Level1");
	}

	//controls the pausing of the scene
	public void pauseControl(){
			if(Time.timeScale == 1)
			{
				Time.timeScale = 0;
				showPaused();
			} else if (Time.timeScale == 0){
				Time.timeScale = 1;
				hidePaused();
			}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
        Debug.Log ("I made it into the showPaused function");
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
            Debug.Log ("I'm toggling you guise");
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
        Debug.Log ("I made it into the hidePaused function");
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
            
		}
	}

	//loads inputted level
	public void LoadMainMenu(){
        //string level
		SceneManager.LoadScene("MainMenuScreen");
	}

    public void ExitGame(){
        Application.Quit();
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// script to change scene manager.
public class Change : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	// change scene.
	//public void move(){
        //Time.timeScale = 1;
		//SceneManager.LoadScene ("Gameplay");
	//}
	public void move()
	{
		Time.timeScale = 1;
		// SceneManager.LoadScene("Part 1 Level");
		SceneManager.LoadScene("PartMenu");
	}
	public void pindah(){
        Data.score = 0;
        SceneManager.LoadScene ("MainMenu");
	}
    public void tutorial()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

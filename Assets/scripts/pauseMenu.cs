using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    //[SerializeField] public string MunculkanSampah;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
	public GameObject PauseScreen;
	public GameObject PauseButton;
	bool GamePaused;

    public void FixedUpdate()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    isPaused = true;
        //    MunculkanSampah.pause = true;
        //}
        //if (isPaused.Equals(true))
        //{
        //    ActiveMenu();
        //}
        //else
        //{
        //    DeactiveMenu();
        //    MunculkanSampah.pause = false;
        //}
		// pause button using escape on keyboard.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused.Equals(true))
            {
                isPaused = true;
                DeactiveMenu();
                MunculkanSampah.pause = true;
                Time.timeScale = 1;
            }
            else
            {
                isPaused = false;
                ActiveMenu();
                MunculkanSampah.pause = false;
                Time.timeScale = 0;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
		GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {
		// if (GamePaused)
			// Time.timeScale = 0;
		// else
			// Time.timeScale = 1;
	}
    void ActiveMenu()
    {
        pauseMenuUI.SetActive(true);
    }
    void DeactiveMenu()
    {
        pauseMenuUI.SetActive(false);
    }

    public void UnPause()
    {
        Time.timeScale = 1;
        DeactiveMenu();
        MunculkanSampah.pause = false;
    }

	public void PauseGame()
	{
		GamePaused = true;
		Time.timeScale = 0;
		PauseScreen.SetActive(true);
		PauseButton.SetActive(false);
	}

	public void ResumeGame()
	{
		GamePaused = false;
		Time.timeScale = 1;
		PauseScreen.SetActive(false);
		PauseButton.SetActive(true);
	}
}

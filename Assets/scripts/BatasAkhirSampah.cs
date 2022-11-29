using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour
{
	public GameObject GameOverPannel;
	bool GameOverPaused;

	private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
		Time.timeScale = 0;
		Data.score = 0;
		GameOverPannel.SetActive(true);
	}
}
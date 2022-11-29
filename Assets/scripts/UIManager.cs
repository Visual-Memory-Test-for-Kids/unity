using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public static UIManager instance;

	public GameObject partSelectionPanel;
	public GameObject[] levelSelectionPanel;

	[Header("Our STAR UI")]
	public int stars;
	public Text starText;
	public PartSelection1[] mapSelections;
	public Text[] questStarsText;
	public Text[] lockedStarsText;
	public Text[] unlokedStarsText;

	/*private void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			if (instance != this)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
		DontDestroyOnLoad(gameObject);
	}

	private void Start()
	{
		PlayerPrefs.DeleteAll();
	}*/

	private void Update()
	{
		UpdateStarUI(); // top star UI.
		UpdateLockedStarUI();
		UpdateUnlockedStarUI();
	}

	public void UpdateLockedStarUI()
	{
		for(int i = 0; i < mapSelections.Length; i++)
		{
			questStarsText[i].text = mapSelections[i].questNumberStar.ToString();
			if (mapSelections[i].isUnlock == false) // if one of the map is locked.
			{
				lockedStarsText[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 3;
			}
		}
	}

	private void UpdateUnlockedStarUI()
	{
		/* for(int i = 0; i < mapSelections.Length; i++)
		{
			unlokedStarsText[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 1;
		} */

		for (int i = 0; i < mapSelections.Length; i++)
		{
			// unlokedStarsText[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 3;
			unlokedStarsText[i].text = stars.ToString() + "/" + mapSelections[i].endLevel * 1;

			switch (i)
			{
				case 0://MARKER MAP 01
					unlokedStarsText[i].text = (PlayerPrefs.GetInt("Lv" + 1) + PlayerPrefs.GetInt("Lv" + 2) + PlayerPrefs.GetInt("Lv" + 3)) + "/" + (mapSelections[i].endLevel - mapSelections[i].startLevel + 1) * 1;
					// unlokedStarsText[i].text = (PlayerPrefs.GetInt("Lv" + 1) + PlayerPrefs.GetInt("Lv" + 2)) + "/" + (mapSelections[i].endLevel - mapSelections[i].startLevel + 1) * 3;
					break;
				case 1://MARKER MAP 02
					unlokedStarsText[i].text = (PlayerPrefs.GetInt("Lv" + 4) + PlayerPrefs.GetInt("Lv" + 5)) + "/" + (mapSelections[i].endLevel - mapSelections[i].startLevel + 1) * 3;
					break;
				case 2://MARKER MAP 03
					unlokedStarsText[i].text = (PlayerPrefs.GetInt("Lv" + 6) + PlayerPrefs.GetInt("Lv" + 7) + PlayerPrefs.GetInt("Lv" + 8) + PlayerPrefs.GetInt("Lv" + 9)) + "/" + (mapSelections[i].endLevel - mapSelections[i].startLevel + 1) * 3;
					break;
				case 3://MARKER MAP 04
					unlokedStarsText[i].text = (PlayerPrefs.GetInt("Lv" + 10) + PlayerPrefs.GetInt("Lv" + 11) + PlayerPrefs.GetInt("Lv" + 12) + PlayerPrefs.GetInt("Lv" + 13)) + "/" + (mapSelections[i].endLevel - mapSelections[i].startLevel + 1) * 3;
					break;
			}
		}
	}
	// increment all levels star reach for top star UI.
	public void UpdateStarUI()
	{
		stars = PlayerPrefs.GetInt("Lv" + 1) + PlayerPrefs.GetInt("Lv" + 2) + PlayerPrefs.GetInt("Lv" + 3) + PlayerPrefs.GetInt("Lv" + 4)
		 + PlayerPrefs.GetInt("Lv" + 5) + PlayerPrefs.GetInt("Lv" + 6) + PlayerPrefs.GetInt("Lv" + 7) + PlayerPrefs.GetInt("Lv" + 8)
			 + PlayerPrefs.GetInt("Lv" + 9) + PlayerPrefs.GetInt("Lv" + 10) + PlayerPrefs.GetInt("Lv" + 11) + PlayerPrefs.GetInt("Lv" + 12)
		  + PlayerPrefs.GetInt("Lv" + 13);
		starText.text = stars.ToString();
	}

	public void PressMapButton(int _mapIndex) // MARKER this method will be triggered when we press the (FOUR) map button.
	{
		if(mapSelections[_mapIndex].isUnlock == true) // we can open this map.
		{
			levelSelectionPanel[_mapIndex].gameObject.SetActive(true);
			partSelectionPanel.gameObject.SetActive(false);
		} else
		{
			// this will be change to popup using panel.
			Debug.Log("We can't open this map now. Please work hard to finish quest!");
		}
	}
	public void BackButton()
	{
		partSelectionPanel.gameObject.SetActive(true);
		for (int i = 0; i < mapSelections.Length; i++)
		{
			levelSelectionPanel[i].gameObject.SetActive(false);
		}
	}
	public void BackMapSelection()//MARKER this method will be call on the SingleLevel button event
	{
		partSelectionPanel.gameObject.SetActive(true);
		for (int i = 0; i < mapSelections.Length; i++)
		{
			levelSelectionPanel[i].gameObject.SetActive(false);
		}
		SceneManager.LoadScene("PartMenu");
	}
}

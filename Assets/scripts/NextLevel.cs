using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
	// this whole code focus: unlock and lock levels inside every part/world/map.
	public int Point_to_Unlocked; // write standard score to unlock next level.
	public GameObject Next_Level; // show pop up image "you win".
	public int max_level;
	public string num_level;
	public static int theLevel;
	public int t; // to unlock next level and initialize right now level.
	// Start is called before the first frame update
	void Start()
    {
		Data.score = 0;
		theLevel = PlayerPrefs.GetInt("theLevel", theLevel);
    }

    // if player hit default score, game object will stop and new level will unlock.
    void Update()
    {
        for(int i = 1; i < max_level; i++)
		{
			if(Data.score == Point_to_Unlocked && LevelUnlocked.level == i)
			{
				Time.timeScale = 0;
				Next_Level.SetActive(true);
			}
		}
    }
	   public static void the_level(int t)
	{
		theLevel = t;
		PlayerPrefs.SetInt("theLevel", theLevel);
		Time.timeScale = 1;
	}
	// if player hit the score system, they can unlock next level by redirect to "PartMenu" scene.
	public void next()
	{
		LevelUnlocked.Next_Level();
		// Application.LoadLevel("Part 1 Level");
		Application.LoadLevel("PartMenu");
	}
	public void _level()
	{
		the_level(t);
		Application.LoadLevel(num_level);
	}
}

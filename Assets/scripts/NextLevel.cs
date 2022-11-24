using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        for(int i = 1; i < max_level; i++)
		{
			if(Data.score == Point_to_Unlocked && LevelUnlocked.level == i)
			{
				Next_Level.SetActive(true);
			}
		}
    }
	   public static void the_level(int t)
	{
		theLevel = t;
		PlayerPrefs.SetInt("theLevel", theLevel);
	}
	public void next()
	{
		LevelUnlocked.Next_Level();
		Application.LoadLevel("Part 1 Level");
	}
	public void _level()
	{
		the_level(t);
		Application.LoadLevel(num_level);
	}
}

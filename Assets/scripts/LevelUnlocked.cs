using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUnlocked : MonoBehaviour
{
	public static int level=1;
	public int max_level;
	public GameObject[] levelUnlocked;
    // Start is called before the first frame update
    void Start()
    {
		level = PlayerPrefs.GetInt("level", level);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=1; i < max_level; i++)
		{
			if(i<=level)
			{
				levelUnlocked[i].SetActive(false);
				Debug.Log("" + level);

			} else
			{
				levelUnlocked[i].SetActive(true);
				Debug.Log("" + level);
			}
		}
    }
	public static void Next_Level()
	{
		if(level == NextLevel.theLevel)
		{
			level += 1;
			PlayerPrefs.SetInt("level", level);
		}
	}
	// reset method -> reset all unlocked level to level 1 and the other level got locked.
	public void Reset()
	{
		level = 1;
		PlayerPrefs.SetInt("level", level);
	}
	// when player hit the score per level, new level will be unlock and player auto go to part 1 scene menu.
	public void add_level()
	{
		Next_Level();
		Application.LoadLevel("Part 1 Level");
	}
}

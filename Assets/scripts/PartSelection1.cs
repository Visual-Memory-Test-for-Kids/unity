using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSelection1 : MonoBehaviour
{
	// this code focus: unlock or locked map/world/part.

	public bool isUnlock = false;
	public GameObject lockGo;
	public GameObject unlockGo;

	public int mapIndex; // the index of the map.
	public int questNumberStar; // how may stars can unlock this map?.
	// this two levels to calculate the next levels.
	public int startLevel;
	public int endLevel;

	public void Update()
	{
		UpdatePartStatus();
		UnlockMap();
	} 

	private void UpdatePartStatus()
	{
		if(isUnlock) // we can play this part!.
		{
			unlockGo.gameObject.SetActive(true);
			lockGo.gameObject.SetActive(false);
		} else // this part still lock now. we have to complete level quest inside part.
		{
			unlockGo.gameObject.SetActive(false);
			lockGo.gameObject.SetActive(true);
		}
	}
	//if our current stars number is great than the request number, which means we can unlock the next map.
	public void UnlockMap()
	{
		if(FindObjectOfType<UIManager>().stars >= questNumberStar) //-> replace to below code.
		//if (UIManager.instance.stars >= questNumberStar)
		{
			isUnlock = true;
		}
		else
		{
			isUnlock = false;
		}
	}
}

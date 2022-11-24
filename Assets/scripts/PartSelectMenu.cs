using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartSelectMenu : MonoBehaviour
{
	public int totalPart = 0; // to indicate how many part on this game menu.
	public int unlockedPart = 1; // which telling how many part have been unlocked by the player before set into one.

	//create array to refer to all the part pattern.
	private PartSelection[] partButtons;

	private int totalPage = 0; // define how many page the menu have.
	private int page = 0; // current page of the menu.
	private int pageItem = 10; // to tell how many part inside our page. in the unity have 10 part for each page, so put 10.

	public GameObject nextButton;
	public GameObject backButton;

	void OnEnable()
	{
		partButtons = GetComponentsInChildren<PartSelection>();
	}

    // Start is called before the first frame update
    void Start()
    {
		Refresh();
    }

	// click next button method.
	public void ClickNext()
	{
		page += 1;
		Refresh();
	}

	//click back button method.
	public void ClickBack()
	{
		page -= 1;
		Refresh();
	}

	// refresh method. to work for every time we need to refresh the part select menu.
	public void Refresh()
	{
		// get the value amount of the total page in this menu.
		totalPage = totalPart / pageItem; // calculate.
		int index = page * pageItem; // concern to identify the level on this page.
		
		for(int i = 0; i < partButtons.Length; i++)
		{
			int part = index + i + 1;
			if (part <= totalPart)
			{
				partButtons[i].gameObject.SetActive(true);
				partButtons[i].Setup(part, part <= unlockedPart);
			}
			else
				partButtons[i].gameObject.SetActive(false);
		}
		CheckButton();
	}

	private void CheckButton()
	{
		backButton.SetActive(page > 0);
		nextButton.SetActive(page < totalPage);
	}
}

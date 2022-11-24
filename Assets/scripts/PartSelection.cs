using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartSelection : MonoBehaviour
{
	public Sprite lockSprite;
	public Text partText;
	private int part = 0; // to indicate which part this button are.
	private Button button; // to refer to the button object.
	private Image image; // need to change the sprite of the image depends whether the button is unlocked.
	
	void OnEnable()
	{
		button = GetComponent<Button>(); // to get reference of the button by using a get component.
		image = GetComponent<Image>(); // followed by get the reference for the image.
	}

	public void Setup (int part, bool isUnlocked)
	{
		this.part = part; // set the level to level.
		partText.text = part.ToString(); // set partText to the amount of the level.

		if (isUnlocked)
		{
			image.sprite = null;
			button.enabled = true;
			partText.gameObject.SetActive(true);
		}
		else // if the part is locked, set the image sprite equal to lock sprite and setting button to enable equal to false also hide the part object.
		{
			image.sprite = lockSprite;
			button.enabled = false;
			partText.gameObject.SetActive(false);
		}
	}

	public void OnClick()
	{

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

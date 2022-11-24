using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class about : MonoBehaviour
{
    public GameObject UI_panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (UI_panel)
        {
            UI_panel.gameObject.SetActive(true);
        }
        else
        {
            //pause = true;
            UI_panel.gameObject.SetActive(false);
        }
    }

}

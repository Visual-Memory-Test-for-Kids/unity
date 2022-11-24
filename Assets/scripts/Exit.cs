using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject exit_panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CLick()
    {
        if (exit_panel)
        {
            exit_panel.gameObject.SetActive(true);
        }
        else
        {
            //pause = true;
            exit_panel.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yesno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btn_Yes()
    {
        Application.Quit();
    }
    public void btn_No()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}

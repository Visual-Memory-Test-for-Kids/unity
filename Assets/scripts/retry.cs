using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retry : MonoBehaviour

{
    public float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 280000000000)
        {
            Data.score = 0;
            Application.LoadLevel("Gameplay");
        }
    }

    public void BtnReplay()
    {
        Time.timeScale = 1;
        Data.score = 0;
        Application.LoadLevel("Gameplay");
    }
}

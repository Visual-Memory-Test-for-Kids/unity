using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{

    private float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 960)
        {
            Data.score = 0;
            SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);

        }
    }

    public void BtnReplay()
    {
        Data.score = 0;
        SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
    }
}

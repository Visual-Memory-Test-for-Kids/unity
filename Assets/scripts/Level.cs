using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Level : MonoBehaviour
{
    public Text ScoreText;
    public float CountInterval = 0.05f, timer = 0;
    int Score = 50, i = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (i < Score && timer >= CountInterval)
        {
            i++;
            ScoreText.text = i.ToString();
            timer = 0;
        }
    }
}
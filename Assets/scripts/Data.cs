using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public static float speed;
    static float defaultSpeed = 2f;

    public static int score;
    public static float CekScore()
    {
        int level = 0;
        level = score / 50;
        speed = defaultSpeed + level;

        return speed;
    }


}

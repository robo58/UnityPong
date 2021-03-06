﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Awake () {                 
Application.targetFrameRate = 60;         
}
    public static int PlayerScore1 = 0;
    public static int PlayerScore2 = 0;
   
    public GUISkin theskin;
    public static void Score(string wallName)
    {
        if(wallName == "rightWall")
        {
            PlayerScore1 ++;
        }
        else
        {
            PlayerScore2 ++;
        }
    }

    void OnGUI()
    {
        GUI.skin = theskin;
        GUI.Label(new Rect(Screen.width/2-150-12,20,100,100),""+PlayerScore1);
        GUI.Label(new Rect(Screen.width/2+150-12,20,100,100),""+PlayerScore2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class finalScoreScript : MonoBehaviour
{
    public Text DisplayFinal;
    float endScore;


    void Update()
    {        
        GetScore();
        GetFinalScore();
    }
    void GetScore()
    {
        endScore = PlayerPrefs.GetFloat("finalScore");  
    }

    public void GetFinalScore()
    {   
        
        DisplayFinal.text = "Final Score: " + endScore.ToString();
    }
}

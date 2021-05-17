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
    //pulls the save of the variable "finalsScore" from ScoreScript.
    void GetScore()
    {
        endScore = PlayerPrefs.GetFloat("finalScore");  
    }

    public void GetFinalScore()
    {   
        
        DisplayFinal.text = "Final Score: " + endScore.ToString();
    }
}

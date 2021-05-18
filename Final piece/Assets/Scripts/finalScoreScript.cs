using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class finalScoreScript : MonoBehaviour
{
    public Text DisplayFinal;
    float endScore;
    float counterSave;
    public GameObject scoreText;

    void Start()
    {
        GameObject script = GameObject.Find("InGameScore"); // reference object with script for access
        ScoreScript ScoreScript = script.GetComponent<ScoreScript>(); // reference script from the reference gameobject above
    }


    void Update()
    {        
        GetScore();
        GetFinalScore();
    }


    
    //pulls the save of the variable "finalScore" from ScoreScript.
    void GetScore()
    {
      endScore = ScoreScript.counterSave; // sets endScore to counterSave from ScoreScript Script
    }

    public void GetFinalScore()
    {   
        DisplayFinal.text = "Final Score: " + endScore.ToString();    //change the text shown on DisplayFinal to show score
    }
}


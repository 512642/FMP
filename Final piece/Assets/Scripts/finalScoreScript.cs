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
        GameObject script = GameObject.Find("InGameScore");
        ScoreScript ScoreScript = script.GetComponent<ScoreScript>();
    }


    void Update()
    {        
        GetScore();
        GetFinalScore();
    }


    
    //pulls the save of the variable "finalScore" from ScoreScript.
    void GetScore()
    {
      endScore = ScoreScript.counterSave;
    }

    public void GetFinalScore()
    {   
        DisplayFinal.text = "Final Score: " + endScore.ToString();        
    }
}


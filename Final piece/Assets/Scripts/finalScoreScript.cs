using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class finalScoreScript : MonoBehaviour
{
    public Text DisplayFinal;
    float endScore;
    public GameObject scoreText;

    void Start()
    {
        ScoreScript ScoreScript = scoreText.GetComponent<ScoreScript>();
    }


    void Update()
    {        
        GetScore();
        GetFinalScore();
    }
    //pulls the save of the variable "finalScore" from ScoreScript.
    void GetScore()
    {
      float endScore = PlayerPrefs.GetFloat("finalScore");
      //  endScore = ScoreScript.SetScore();

    }

    public void GetFinalScore()
    {   
        
        DisplayFinal.text = "Final Score: " + endScore.ToString(); 
        
    }
}

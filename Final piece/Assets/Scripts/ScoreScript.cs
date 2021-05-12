using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float score = 0;
    Text inGameScore;
    Text finalScoreText;
    private float finalScore = 0;

    //void Update()
    //{
     //   if ()
       // {
         //   afasfaf;
       // }
    //}


    public void Score()
    {
        //inGameScore = GameObject.Find("InGameScore").GetComponent<Text>();
        score += Time.deltaTime;
        print(score);
        //inGameScore.text = "Score:" + score;
  
    }
    /*public void FinalScore()
    {
        finalScoreText = GameObject.Find("ScoreDisplay").GetComponent<Text>();
        finalScore = score; 


        finalScoreText.text = "Final Score: " + finalScore;
    }*/
}

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


    public void UpdateScore()
    {
        inGameScore = GameObject.Find("InGameScore").GetComponent<Text>();
        score += Time.deltaTime;
        print(score);
    }
    /*public void FinalScore()
    {
        finalScoreText = GameObject.Find("ScoreDisplay").GetComponent<Text>();
        score = 


        finalScoreText.text = "Final Score: " + finalScore;
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{    
    int score;
    public float finalScore;
    public float counter = 0;
    public Transform player;
    public Text scoreText;
    public float multiplyer = 100;



    void Update()
    {
        score = Mathf.RoundToInt(counter * multiplyer);
        counter = counter + Time.deltaTime;                         //adds 1 100 times per second due to the multiplyer above.
        scoreText.text = "Score: " + score.ToString();              // prints score: *score*.
        TimeSpan time = TimeSpan.FromSeconds(counter); 
        finalScore = score;       
    }
    
    //creates the save for "finalScore" to store the score.
    public void SetScore(float finalScore, float counter)
    {
        PlayerPrefs.SetFloat("finalScore", finalScore);
    }

    }

    

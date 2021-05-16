using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour
{
    int score;
    float counter = 0;
    public Transform player;
    public Text scoreText;
    public float multiplyer = 5000;

    void Update()
    {
        score = Mathf.RoundToInt(counter * multiplyer);
        counter = counter + Time.deltaTime;
        scoreText.text = score.ToString();
        TimeSpan time = TimeSpan.FromSeconds(counter);
    }


}

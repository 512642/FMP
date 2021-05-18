using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public ScoreScript ScoreScript; // gives access to ScoreScript script.

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Quit()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Pause()
    {
        SceneManager.LoadScene("Main menu");
    }
}

    


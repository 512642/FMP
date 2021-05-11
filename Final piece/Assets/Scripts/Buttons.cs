using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("AlsoGame", LoadSceneMode.Additive);
    }

    public void Pause()
    {
        SceneManager.LoadScene("Game");
    }
}

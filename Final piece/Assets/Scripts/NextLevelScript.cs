using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{


public void NextScene()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

public void MainMenuReturn()
{
    SceneManager.LoadScene("Main Menu");
}

void OnCollisionEnter2D(Collision2D col)
{
    if (col.gameObject.tag == "Player")
    {
        print("LevelComplete!");
        NextScene();
    }
}
}

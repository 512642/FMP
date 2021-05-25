using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{

public void MainMenuReturn()
{
    SceneManager.LoadScene("Main Menu");
}
public void RetryLevel1()
{
    SceneManager.LoadScene("Level 1");
}



}

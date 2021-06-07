using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{

 GameObject Level1Layout = GameObject.Find("Level 1 Layout");
 GameObject Level2Layout = GameObject.Find("Level 2 Layout");

public void MainMenuReturn()
{
    SceneManager.LoadScene("Main Menu");
}
public void RetryLevel1()
{
    SceneManager.LoadScene("Level 1");
}

public void PlaySurvival()
{
    SceneManager.LoadScene("Survival");

}


}

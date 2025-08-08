using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void settingsMenu()
    {
        SceneManager.LoadScene("Settings");
    }
    public void quitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //when the player clicks on the play button it loads the first scene
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //when the player clicks on the quit button it displays message in console
    public void QuitGame()
    {
        Debug.Log("Player Has Quit The Game!");
        Application.Quit();
    }
}

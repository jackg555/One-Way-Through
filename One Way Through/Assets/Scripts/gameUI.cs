using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameUI : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject gameOverUi;
    public GameObject levelCompleteUi;
    public GameObject pauseButton;
    public GameObject restartButton;
    public GameObject displayMessage = null;
    public GameObject levelTitle;

    //deletes the message on screen after 10 seconds
    void Start()
    {
        Destroy(displayMessage, 10);
    }

    void Update()
    {
        //controls pause menu when escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    //resumes the game
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(true);
        restartButton.SetActive(true);
        levelTitle.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    //pauses the game
    public void Paused()
    {
        pauseMenuUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //restarts the game
    public void RestartGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //loads the main menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    //displays gameover screen
    public void GameOver()
    {
        gameOverUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //displays level complete screen
    public void LevelComplete()
    {
        levelCompleteUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    //changes scene to the next level
    public void NextLevel()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

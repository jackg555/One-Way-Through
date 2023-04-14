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

    // Start is called before the first frame update
    void Start()
    {
        Destroy(displayMessage, 4);
    }

    // Update is called once per frame
    void Update()
    {
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

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        pauseButton.SetActive(true);
        restartButton.SetActive(true);
        levelTitle.SetActive(true);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void Paused()
    {
        pauseMenuUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void GameOver()
    {
        gameOverUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void LevelComplete()
    {
        levelCompleteUi.SetActive(true);
        pauseButton.SetActive(false);
        restartButton.SetActive(false);
        levelTitle.SetActive(false);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelComplete : MonoBehaviour
{
    gameUI levelCompleted;
    bool hasRun = false;

    void Start()
    {
        levelCompleted = GameObject.FindGameObjectWithTag("Canvas").GetComponent<gameUI>();
    }

    //when the player reaches the end of the level it calls the "levelComplete" function in the "gameUI" script
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!hasRun)
            {
                levelCompleted.LevelComplete();
                hasRun = true;
            }
        }
    }
}

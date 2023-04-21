using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    gameUI gameOver;
    bool hasRun = false;

    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("Canvas").GetComponent<gameUI>();
    }

    //calls "gameOver" function in the "gameUI" script when the player comes in contact with the trap
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasRun)
        {
            gameOver.GameOver();
            hasRun = true;
        }
    }
}

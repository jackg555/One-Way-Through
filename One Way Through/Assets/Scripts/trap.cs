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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasRun)
        {
            gameOver.GameOver();
            hasRun = true;
        }
    }
}

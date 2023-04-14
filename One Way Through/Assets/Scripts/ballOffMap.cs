using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballOffMap : MonoBehaviour
{
    int respawnHeight = -10;
    gameUI gameOver;
    bool hasRun = false;

    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("Canvas").GetComponent<gameUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < respawnHeight && !hasRun)
        {
            gameOver.GameOver();
            hasRun = true;
        }
    }
}

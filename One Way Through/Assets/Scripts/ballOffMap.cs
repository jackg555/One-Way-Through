using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballOffMap : MonoBehaviour
{
    public int respawnHeight = -5;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < respawnHeight)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

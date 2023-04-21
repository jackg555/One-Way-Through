using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public int level;

    //when the player clicks on a level it opens the corresponding scene
    public void OpenScene()
    {
        SceneManager.LoadScene("Level_" + level.ToString());
    }
}

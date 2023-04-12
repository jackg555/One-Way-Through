using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    // Start is called before the first frame update
    void Start()
    {
        //door1.SetActive(true);
        //door2.SetActive(false);
    }

    void OnTriggerEnter(Collider gameBall)
    {
        if (door1.active)
        {
            door1.SetActive(false);
            door2.SetActive(true);
        }
        else
        {
            door1.SetActive(true);
            door2.SetActive(false);
        }
    }
}

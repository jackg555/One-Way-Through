using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;

    //opens and closes doors ingame when the players goes over the corresponding button
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
}

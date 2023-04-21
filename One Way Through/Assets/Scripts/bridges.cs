using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridges : MonoBehaviour
{
    public GameObject bridge;

    //when the ball comes in contact with the bridges button it opens the bridge
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bridge.SetActive(true);
        }
    }
}

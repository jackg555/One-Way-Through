using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotKey : MonoBehaviour
{
    public GameObject lockAndKey;

    //when the player touches the key it opens the corresponding door
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(lockAndKey);
        }
    }
}

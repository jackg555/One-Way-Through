using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gotKey : MonoBehaviour
{
    public GameObject lockAndKey;

    void OnTriggerEnter(Collider gameBall)
    {
        Destroy(lockAndKey);
    }
}

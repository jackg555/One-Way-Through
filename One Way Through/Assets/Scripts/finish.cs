using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    void OnTriggerEnter(Collider gameBall)
    {
        Debug.Log("Finished");
    }
}

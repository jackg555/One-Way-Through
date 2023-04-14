using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public bool changeVelocity = false;
    public GameObject ball;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(changeVelocity == true)
            {
                ball.GetComponent<Rigidbody>().velocity *= -1;
                ball.GetComponent<Rigidbody>().angularVelocity *= -1;
            }
            ball.transform.position = spawnPoint.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    public bool changeVelocity = false;
    public GameObject ball;
    public Transform spawnPoint;

    //when the player touches on portal it moves the ball to the other portal
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //changes ball velocity to make the ball go in the opposite dirrection
            if(changeVelocity == true)
            {
                ball.GetComponent<Rigidbody>().velocity *= -1;
                ball.GetComponent<Rigidbody>().angularVelocity *= -1;
            }
            ball.transform.position = spawnPoint.transform.position;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltBoard : MonoBehaviour
{
    public float tiltSpeed = 4.0f;
    public float tiltAngle = 25.0f;

    //tilts the board when the user uses the arrow keys or "wasd"
    void Update()
    {
        float vRotation = Input.GetAxis("Vertical") * tiltAngle;
        float hRotation = Input.GetAxis("Horizontal") * tiltAngle * -1;

        Quaternion bRotation = Quaternion.Euler(vRotation, 0.0f, hRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, bRotation, Time.deltaTime* tiltSpeed);
    }
}

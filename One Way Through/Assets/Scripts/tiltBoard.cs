using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltBoard : MonoBehaviour
{
    public float tiltSpeed = 4.0f;
    public float tiltAngle = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float vRotation = Input.GetAxis("Vertical") * tiltAngle;
        float hRotation = Input.GetAxis("Horizontal") * tiltAngle * -1;

        Quaternion bRotation = Quaternion.Euler(vRotation, 0.0f, hRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, bRotation, Time.deltaTime * tiltSpeed);
    }
}

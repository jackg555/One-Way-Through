using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballOffMap : MonoBehaviour
{
    public int respawnHeight = -5;
    Vector3 orginalPosition;
    // Start is called before the first frame update
    void Start()
    {
        orginalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < respawnHeight)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            transform.position = orginalPosition;
        }
    }
}

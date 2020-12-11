using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody body;
    public int step;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            body.AddForce(-step, 0, 0);

        if (Input.GetKey(KeyCode.S))
            body.AddForce(step, 0, 0);

        if (Input.GetKey(KeyCode.A))
            body.AddForce(0, 0, -step);

        if (Input.GetKey(KeyCode.D))
            body.AddForce(0, 0, step);
    }
}

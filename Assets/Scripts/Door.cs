using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            door.transform.Rotate(0, 90, 0);
        }
    }

    bool IsOpened;
    float LastTriggerStayTime;

    public GameObject door;


    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
    }

    void Update()
    {
        CloseDoor();
    }

    public void CloseDoor()
    {
        door.transform.Rotate(0, 0, 0);
    }
}

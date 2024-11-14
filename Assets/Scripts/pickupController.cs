
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupController : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("User"))
        {
            GameObject[] closedDoors = GameObject.FindGameObjectsWithTag("ClosedDoor");
            foreach (GameObject door in closedDoors)
            {
                door.tag = "OpenDoor";
            }

            Destroy(gameObject);
        }
    }
}

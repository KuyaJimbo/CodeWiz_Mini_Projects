using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type: how we can access the variable (public/private)
    // Data_Type: what type of data the variable holds (int, float, string, etc.)
    // Variable_Name: the name of the variable (should be descriptive of what it does)

    // Challenge 1: Create a PUBLIC SPEED variable (Float is a decimal number)
    // Example: public float speed;

    /* -- ENTER YOUR CODE HERE -- */

    // Start is called before the first frame update
    void Start()
    {
        // -- GIVE SPEED A DEFAULT VALUE --

        // if (speed == 0)
        // {
        //     // Give a Default value
        //     speed = 5f;
        // }

        // -- SET BULLET DESTROY TIME --
        // Let's destroy the bullet after 3 seconds so it does not go off-screen
        // Example: Destroy(gameObject, 3f);

        /* -- ENTER YOUR CODE HERE -- */
    }

    // Update is called once per frame
    void Update()
    {
        // --- CONTROL BULLET MOVEMENT --- 
        // Move the bullet forward based on SPEED
        // Example: transform.Translate(Vector2.up * speed * Time.deltaTime);

        /* -- ENTER YOUR CODE HERE -- */
    }
}

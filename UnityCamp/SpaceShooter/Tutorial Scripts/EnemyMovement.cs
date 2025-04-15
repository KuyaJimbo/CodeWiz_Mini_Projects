using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
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

        /* -- ENTER YOUR CODE HERE -- */


    }

    // Update is called once per frame
    void Update()
    {
        // --- CONTROL ENEMY MOVEMENT --- 
        // Move the bullet down based on SPEED
        // Example: transform.Translate(Vector2.down * speed * Time.deltaTime);

        /* -- ENTER YOUR CODE HERE -- */


        // -- DESTROY THE ENEMY IF IT GOES OFF SCREEN --
        // if (transform.position.y < -6)
        // {
        //     Destroy(gameObject);
        // }

        /* -- ENTER YOUR CODE HERE -- */

    }
}

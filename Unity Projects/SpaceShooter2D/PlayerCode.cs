using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make sure to have the following components:
// 1. Rigidbody2D (with Gravity Scale set to 0)
// 2. BoxCollider2D (or any other collider that fits your player shape)
// 3. SpriteRenderer (to display the player sprite)

public class PlayerCode : MonoBehaviour
{
    // HOW TO CREATE A VARIABLE:
    // Variables have 3 parts:
    // Access_Type   Data_Type   Variable_Name;

    public float speed; // Speed of the player
    public float horizontalInput; // Input value for movement

    // *** CHALLENGE 1: Create a PUBLIC variable for the verticalInput and make sure it is a FLOAT ***


    // Start is called before the first frame update
    void Start()
    {
        speed = 5f; // Set the speed to a default value
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input (A/D keys or left/right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // if the player presses the left arrow key or 'A' key, move left
        if (moveInput < 0)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        // if the player presses the right arrow key or 'D' key, move right
        else if (moveInput > 0)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        // * CHALLENGE 2: Move the player up and down using the vertical input (W/S keys or up/down arrow keys)

        /*
        float verticalInput = Input.GetAxis("__________");

        if (verticalInput _ 0)
        {
            _________._________(Vector2.____ * _____ * Time.deltaTime);
        }
        else if (verticalInput _ 0)
        {
            _________._________(Vector2.__ * _____ * Time.deltaTime);
        }
        */


        // EXAMPLE: Shoot bullets when the left mouse button is pressed
        // if (Input.GetMouseButtonDown(0))
        // {
        //     // Instantiate spawns a GAMEOBJECT at a POSITION with a ROTATION
        //     Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        // }

        // * CHALLENGE 3: Make the player shoot bullets when the space bar is pressed (HINT: Use Input.GetKeyDown(KeyCode.Space))
        /* 
        if (Input.GetKeyDown(KeyCode._____))
        {
            Instantiate(____________, _________.________, Quaternion.identity);
        }
        */

    }
}

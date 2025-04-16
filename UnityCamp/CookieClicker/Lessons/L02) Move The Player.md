# L2) Move the Player

## Add the Player Movement Script to the Player Object

1. Select the **Player Object** in the **Scene**

2. Click **Add Component** in the **Inspector**
3. Select the **Player Movement** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

### // HOW TO CREATE A VARIABLE:

// Variables have 3 parts:

// **Access_Type**: how we can access the variable (public/private)

// **Data_Type**: what type of data the variable holds (int, float, string, etc.)

// **Variable_Name**: the name of the variable (should be descriptive of what it does)

// Here's how we create a PUBLIC SPEED variable (Float is a decimal number)
public float speed;

// Here's how we create a PRIVATE HORIZONTALINPUT variable (Float is a decimal number)
private float horizontalInput;

### // Challenge 1: Create a PRIVATE VERTICALINPUT variable as a float

    private float verticalInput;

### // Start is called before the first frame update

    void Start()
    {
    	// -- GIVE SPEED A DEFAULT VALUE --
    	if (speed == 0)
    	{
        	// Give a Default value
    	    speed = 5f;
    	}
    }

### // Update is called once per frame

    void Update()
    {

        // Inputs are the keys the player presses on the keyboard or controller
        // We can use the Input class to get the input values

        // --- CONTROL HORIZONTAL MOVEMENT ---
        // Get the horizontal input (A/D keys or left/right arrow keys)
        horizontalInput = Input.GetAxis("Horizontal");
        // Move the player left/right based on horizontal input
        transform.Translate(Vector2.right * horizontalInput * speed * Time.deltaTime);

        // --- CONTROL  VERTICAL  MOVEMENT ---
        // Get the vertical input (W/S keys or up/down arrow keys)
        verticalInput = Input.GetAxis("Vertical");
        // Move the player up/down based on vertical input
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);
    }

}

## Now test out your game by clicking the Play Button

**Input Controls:**

- WASD
- Arrow Keys

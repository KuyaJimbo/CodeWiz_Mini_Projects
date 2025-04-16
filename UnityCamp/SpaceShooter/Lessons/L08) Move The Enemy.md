# L8) Move the Enemy

## Add the Enemy Movement Script to the Player Object

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

### // Challenge 1: Create a PUBLIC SPEED variable (Float is a decimal number)

    public float speed;

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

        // -- CONTROL ENEMY MOVEMENT -- 
        // Move the bullet down based on SPEED
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // -- DESTROY THE ENEMY IF IT GOES OFF SCREEN --
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

}

## Now test out your game by clicking the Play Button

The Enemy should start moving **downward** by the **Speed** you set.
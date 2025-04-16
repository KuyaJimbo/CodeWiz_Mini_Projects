# L2) Move the Projectile

## Add the Projectile Movement Script to the Player Object

1. Select the **Projectile Object** in the **Scene**

2. Click **Add Component** in the **Inspector**
3. Select the **Projectile Movement** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class ProjectileMovement : MonoBehaviour

{

### // HOW TO CREATE A VARIABLE:

// Variables have 3 parts:

// **Access_Type**: how we can access the variable (public/private)

// **Data_Type**: what type of data the variable holds (int, float, string, etc.)

// **Variable_Name**: the name of the variable (should be descriptive of what it does)

### // CHALLENGE 1: Create a PUBLIC SPEED variable as a float

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

            // -- SET BULLET DESTROY TIME --
            // Let's destroy the bullet after 3 seconds so it does not go off-screen
            Destroy(gameObject, 3f);
    }

### // Update is called once per frame

    void Update()
    {

        // --- CONTROL BULLET MOVEMENT ---
        // Move the bullet forward based on SPEED
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

}

## Now test out your game by clicking the Play Button

**Input Controls:**

- WASD
- Arrow Keyes

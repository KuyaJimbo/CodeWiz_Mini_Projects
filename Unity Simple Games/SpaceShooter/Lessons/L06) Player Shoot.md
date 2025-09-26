# L6) Player Shoot

## Add the Player Shoot Script to the Player Object

1. Select the **Player Object** in the **Scene**

2. Click **Add Component** in the **Inspector**

3. Select the **Player Shoot** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerShoot : MonoBehaviour

{

### // HOW TO CREATE A VARIABLE:

// Variables have 3 parts:

// **Access_Type**: how we can access the variable (public/private)

// **Data_Type**: what type of data the variable holds (int, float, string, etc.)

// **Variable_Name**: the name of the variable (should be descriptive of what it does)

### // Challenge 1: Create a PUBLIC PROJECTILEPREFAB variable (Data Type: GameObject)

    public GameObject projectilePrefab;

### // Challenge 2: Create a PUBLIC shootSound variable (Data Type: AudioClip)

    public AudioClip shootSound;

### // Start is called before the first frame update

    void Start()
    {

    }

### // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // INSTANTIATE creates a GAMEOBJECT at a POSITION with a ROTATION
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // PLAYCLIPATPOINT plays an AUDIOCLIP at a specific position in the game world
            AudioSource.PlayClipAtPoint(shootSound, transform.position);
        }
    }

}

## Player needs a Projectile!

Remember that **Projectile Prefab** we just made? The Player needs it to shoot!

1) Select the **Player** Object in Unity

2) Look for the **Player Shoot** Script in the **Inspector** and find the **projectilePrefab** field

3) Click and Drag your **Projectile Prefab** and into the **projectilePrefab** field 

## Player needs a Shoot Sound!

There should be a folder called **Sounds** in the **Project Files**.

Select a sound and press the Play button in the Inspector to hear it.

1) Select the **Player** Object in Unity

2) Look for the **Player Shoot** Script in the **Inspector** and find the **shootSound** field

3) Click and Drag your **Sound** and into the **projectilePrefab** field 

## Now test out your game by clicking the Play Button

**Shoot Control:**

- Space Bar

# Want more Sounds?

You can find a whole library of Sound Files on https://scratch.mit.edu/

1) Navigate to the **Sounds Library**

    Create Button > Sounds Tab > Choose a Sound Button

2) Select a Sound and Export it
    
    **Right-Click** on the sound and select **export**

3) Reopen **Unity** and **Right-Click** in the **Project Files** section at the bottom of your screen.
4) Click **Import New Asset...**
5) Open the **Download Folder**, select your **sound**, and click **Import**
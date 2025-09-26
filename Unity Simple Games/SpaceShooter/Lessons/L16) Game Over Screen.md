# L16) Game Over Screen

This lesson teaches how to display **more** UI Elements such as Text, Images, or Buttons to design a Game Over Screen.

## Make a UI Image for the Game Over Screen

In the **Hierarchy**, add a UI Image Game Object and name it "Game Over Screen"

- UI > Image

Adjust the Position of the Game Over Screen

## Make a UI Button for the Score Space

In the **Hierarchy**, add a UI Text Game Object and name it "Score Text"

- UI > Text - TextMeshPro 
    
    (If asked, Import TMP Essentials)

## In the Inspector notice 4 COMPONENTS have been created for the Button

**Rect Transform**

**Canvas Renderer**

**Image**

**Button**

- Controls the Button that is shown and its style

## Adjust the Position of the Button

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Select the **Score Text** Object use the **Move Tool** to position it inside of the Score Space

3) Use the **Rect Transform** component to adjust the Width and Height

## The Button should be a CHILD OBJECT of the Game Over Screen

A child?! Don't worry, a child object simply means it is part of something else.

1) Select the Button Game object in the Hierarchy

2) Click and Drag it on top of the Game Over Screen Object in the Hierarchy

The Game Over Screen is the Parent Object and the Button is the Child Object.

## This Button is our RESTART BUTTON

The Game Manager already has the code to Replay the Level, we just need to connect it to the Button!

1) Select the Button Game Object in the Hierarchy

2) Look for the Button Component in the Inspector

3) Click on the **+** under the On Click() Box to add an event

4) Click and drag the Game Manager Object from the Inspector into the Object field

5) Click on the Drop-Down labeled "No Function"

6) Select **Game Manager >** and then select **ReplayLevel()**

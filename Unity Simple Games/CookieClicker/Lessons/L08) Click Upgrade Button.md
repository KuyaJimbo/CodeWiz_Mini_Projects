# L8) Click Upgrade Button

This lesson teaches how to make a UI Button for your Upgrades

## Remember, What is a User Interface?

A User Interface is a visual element which the user can interact with.

Examples:

- Restart Button
- Score Text
- Game Over Image (or Screen)

## Make a UI Button for the Click Upgrade

In the **Hierarchy**, add a UI Image Game Object and name it "Click Upgrade Button"

- UI > Button - TextMeshPro

## Try to adjust the Position and the Size of the Click Upgrade

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Use the **Rect Transform** component or the **Scene Tools (Ex: Move Tool, Rect Tool)**

## In the Inspector notice 4 COMPONENTS have been created for the Button

**Rect Transform**

**Canvas Renderer**

**Image**

**Button**

- Controls the text that is shown and its style

## Play around with the Colors!

- The **Button** Component has a lots of **Color** properties

- Feel free to experiment with the colors and play the game to test it.

## Edit the Text inside the Button!

1) In the **Hierarchy**, Click the Triangle next to the Click Upgrade Button to show the Text (TMP) Game Object

2) Click the Text Game Object to see its properties in the Inspector

3) Update the TextMeshPro - Text (UI) Component so the Text Shows the Boost and Cost

#### Here's an example:

    +1 Cookie Per Click

    Cost: 20 Cookies

## Great! Next we will make a Script for this Click Upgrade.
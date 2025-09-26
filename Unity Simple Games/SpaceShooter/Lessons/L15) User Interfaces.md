# L15) User Interfaces (UI)

This lesson teaches how to display the UI Elements such as Text, Images, or Buttons.

## What is a User Interface

A User Interface is a visual element which the user can interact with.

Examples:

- Restart Button
- Score Text
- Game Over Image (or Screen)

## Make a UI Image for the Score Space

In the **Hierarchy**, add a UI Image Game Object and name it "Score Space"

- UI > Image

## In the Inspector notice 3 COMPONENTS have been created for the Image

**Rect Transform**

- Controls WHERE the UI Game Object is

**Canvas Renderer**

- This helps draw our UI onto the Canvas

**Image**

- Controls the Image we see on the Canvas

## Adjust the Position of the Score Space

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Select the **Score Space** Object use the **Move Tool** to position it at the top of the screen
3) Use the **Rect Transform** component to adjust the Width and Height

## Make a UI Text for the Score Space

In the **Hierarchy**, add a UI Text Game Object and name it "Score Text"

- UI > Text - TextMeshPro 
    
    (If asked, **Import TMP Essentials**)

## In the Inspector notice 3 COMPONENTS have been created for the Text

**Rect Transform**

**Canvas Renderer**

**TextMeshPro - Text (UI)**

- Controls the text that is shown and its style

## Adjust the Position of the Score Space

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Select the **Score Text** Object use the **Move Tool** to position it inside of the Score Space

3) Use the **Rect Transform** component to adjust the Width and Height

## Play around with the Colors!

- The **Image** Component has a **Color** property

- The ****TextMeshPro - Text (UI)** Component has a **Vertex** Property

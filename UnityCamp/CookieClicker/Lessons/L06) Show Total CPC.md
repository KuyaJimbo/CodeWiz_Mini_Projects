# L6) Show Total CPC (Cookies Per Click)

This lesson teaches how to display the UI Elements such as Text, Images, or Buttons.

Note: CPC stands for Cookies Per Click

## Remember, What is a User Interface?

A User Interface is a visual element which the user can interact with.

Examples:

- Restart Button
- Score Text
- Game Over Image (or Screen)

## Make a UI Image for the CPC Space

In the **Hierarchy**, add a UI Image Game Object and name it "CPC Space"

- UI > Image

## Adjust the Position of the CPC Space

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Select the **CPC Space** Object use the **Move Tool** to position it at the top of the screen

3) Use the **Rect Transform** component to adjust the Width and Height

## Make a UI Text for the CPC Space

In the **Hierarchy**, add a UI Text Game Object and name it "CPC Text"

- UI > Text - TextMeshPro 
    
    (If asked, **Import TMP Essentials**)


## Adjust the Position and Size of the CPC Space

1) Double-Click on the **Canvas** Object in the **Hierarchy** to Zoom our focus on it

2) Select the **CPC Text** Object use the **Move Tool** to position it inside of the **CPC Space**

3) Use the **Rect Transform** component to adjust the Width and Height

## Play around with the Colors!

- The **Image** Component has a **Color** property

- The ****TextMeshPro - Text (UI)** Component has a **Vertex** Property

## Update the UI Manager Script 

1. Select the **UI Manager Object**
   
2. Double-Click the **UI Manager** script in the **Inspector** to reopen the it

## Open the Script and Fix the Code! (Update Function is Missing)

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using TMPro;

public class UIManager : MonoBehaviour

{

    // References to UI Text elements
    public TextMeshProUGUI TotalCookiesText;

    public TextMeshProUGUI CookiesPerClickText;

## // Update is called once per frame
    private void Update()
    {
        // Update UI elements with current values
        TotalCookiesText.text = "Cookies: " + Mathf.Floor(CookieManager.TotalCookies).ToString("N0");
        
        CookiesPerClickText.text = "Per Click: " + CookieManager.CookiesPerClick.ToString("N1");


    }

}

## Good Job! Return to Unity and make sure it does not give any Errors. 

## Finally, give the Game Manager Object the Cookie Count Text

1) Select the Game Manager Object in the Hierarchy

2) Drag the Cookie Count Text Object from the Hierarchy into the Game Manager's 

## Now, test out your game!
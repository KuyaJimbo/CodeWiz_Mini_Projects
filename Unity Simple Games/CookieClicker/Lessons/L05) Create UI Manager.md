# L5) Create the UI Manager Object

Now we need **something** to update the Total Cookies Text.

## Let's create an Object with a Script that updates the Text

In the **Hierarchy**, add an Empty Game Object and name it "UI Manager"

- Create Empty

## Add the UI Manager Script 

1. Select the **UI Manager Object**
   
2. Click **Add Component** in the **Inspector**

3. Select the **UI Manager** Script

## Check out the Script!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using TMPro;

public class UIManager : MonoBehaviour

{

    // References to UI Text elements
    public TextMeshProUGUI TotalCookiesText;

## // Update is called once per frame
    private void Update()
    {
        // Update UI elements with current values
        TotalCookiesText.text = "Cookies: " + Mathf.Floor(CookieManager.TotalCookies).ToString("N0");

        
    }

}

## Good Job! Return to Unity and make sure it does not give any Errors. 

## Finally, give the Game Manager Object the Cookie Count Text

1) Select the Game Manager Object in the Hierarchy

2) Drag the Cookie Count Text Object from the Hierarchy into the Game Manager's Total Cookies Text

## Now, test out your game! The Cookie Text should show the total cookies now.
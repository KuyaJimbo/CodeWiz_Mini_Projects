# L3) Click for Cookies

## Add the Cookie Target Script to the Cookie Target Object

1. Select the **Cookie Target Object** in the **Scene**

2. Click **Add Component** in the **Inspector**

3. Select the **Cookie Target** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CookieTarget : MonoBehaviour

{

// This script handles clicks on the cookie

### // OnMouseDown() is called when the mouse button is down over the GameObject
    private void OnMouseDown()
    {
        // Increase total cookies by cookies per click amount when clicked
        CookieManager.TotalCookies += CookieManager.CookiesPerClick;

        // Scale the cookie up and down for a visual effect
        transform.localScale *= 1.2f;
    }

### // OnMouseUp() is called when the mouse button is released over the GameObject
    private void OnMouseUp()
    {
        // Start the coroutine to scale the cookie
        transform.localScale /= 1.2f;
    }

}

## The Cookie Target needs a CircleCollider2D so it knows when the Mouse touches it

1. Select the **Cookie Target Object** in the **Scene**

2. Click **Add Component** in the **Inspector**

3. Select the **CircleCollider2D** component

## Now test out your game by clicking the Cookie Target
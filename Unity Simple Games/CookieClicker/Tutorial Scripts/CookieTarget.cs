using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieTarget : MonoBehaviour
{
    // This script handles clicks on the cookie

    // OnMouseDown is called when the mouse button is pressed over the GameObject
    private void OnMouseDown()
    {
        // Increase total cookies by cookies per click amount when clicked
        // CookieManager.TotalCookies += CookieManager.CookiesPerClick;


        // Scale the cookie up and down for a visual effect
        // transform.localScale *= 1.2f;

    }

    // OnMouseUp is called when the mouse button is released over the GameObject
    private void OnMouseUp()
    {
        // Start the coroutine to scale the cookie
        // transform.localScale /= 1.2f;
        
    }
}
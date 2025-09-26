using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // References to UI Text elements
    public TextMeshProUGUI TotalCookiesText;

    // Create a PUBLIC variable for CookiesPerClickText as a TextMeshProUGUI type
    // public TextMeshProUGUI CookiesPerClickText;

    // Create a PUBLIC variable for CookiesPerSecondText as a TextMeshProUGUI type
    // public TextMeshProUGUI CookiesPerSecondText;

    // Update is called once per frame
    private void Update()
    {
        // Update UI elements with current values
        TotalCookiesText.text = "Cookies: " + Mathf.Floor(CookieManager.TotalCookies).ToString("N0");  
    
    }
}
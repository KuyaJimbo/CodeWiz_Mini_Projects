using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    // References to UI Text elements
    public TextMeshProUGUI TotalCookiesText;
    public TextMeshProUGUI CookiesPerSecondText;
    public TextMeshProUGUI CookiesPerClickText;

    private void Update()
    {
        // Update UI elements with current values
        if (TotalCookiesText != null)
        {
            TotalCookiesText.text = "Cookies: " + Mathf.Floor(CookieManager.TotalCookies).ToString("N0");
        }
        
        if (CookiesPerSecondText != null)
        {
            CookiesPerSecondText.text = "Per Second: " + CookieManager.CookiesPerSecond.ToString("N1");
        }
        
        if (CookiesPerClickText != null)
        {
            CookiesPerClickText.text = "Per Click: " + CookieManager.CookiesPerClick.ToString("N1");
        }
    }
}
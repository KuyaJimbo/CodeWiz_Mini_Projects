using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeClick : MonoBehaviour
{
    // Properties for this upgrade
    public float Cost;
    public float Boost; 
    public int Count;

    // Cost increase multiplier
    public float CostMultiplier = 1.2f;

    public void Purchase()
    {
        // Check if player has enough cookies to purchase
        if (CookieManager.TotalCookies >= Cost)
        {
            // Purchase the upgrade
            CookieManager.TotalCookies -= Cost;
            Count++;
            CookieManager.CookiesPerClick += Boost;
            
            // Increase cost for next purchase
            Cost = Mathf.Floor(Cost * CostMultiplier);
        }
    }
}
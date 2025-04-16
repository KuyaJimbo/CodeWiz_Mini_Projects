using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeProduction : MonoBehaviour
{
    // Properties for this upgrade
    public float Cost;
    public float Boost;
    public int Count;

    // Cost increase multiplier
    public float CostMultiplier = 1.15f;

    public void Purchase()
    {
        // Check if player has enough cookies to purchase
        if (CookieManager.TotalCookies >= Cost)
        {
            // Purchase the upgrade
            CookieManager.TotalCookies -= Cost;
            Count++;
            CookieManager.CookiesPerSecond += Boost;
            
            // Increase cost for next purchase
            Cost = Mathf.Floor(Cost * CostMultiplier);
        }
    }
}
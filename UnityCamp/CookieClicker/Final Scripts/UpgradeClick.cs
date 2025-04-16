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
    public float CostMultiplier;

    // Give Default Values
    private void Start()
    {
        // Set the Cost
        if (Cost == 0)
        {
            Cost = 10;
        }

        // Set the Boost
        if (Boost == 0)
        {
            Boost = 1;
        }

        // Reset the Count to 0
        Count = 0;

        // Set the CostMultiplier
        if (CostMultiplier == 0)
        {
            CostMultiplier = 1.5f;
        }
    }

    // Method to purchase the upgrade
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
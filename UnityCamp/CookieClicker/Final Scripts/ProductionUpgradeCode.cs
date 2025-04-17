using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionUpgradeCode : MonoBehaviour
{
    // Properties for this upgrade
    public float Cost;
    public float Boost;
    public int Count;

    // Start is called before the first frame
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    // Method to purchase the upgrade
    public void Purchase()
    {
        // Check if player has enough cookies to purchase
        if (CookieManager.TotalCookies >= Cost)
        {
            // Decrease the Total Cookies by the Cost
            CookieManager.TotalCookies -= Cost;

            // Increase the Cookies per Second by the Boost
            CookieManager.CookiesPerSecond += Boost;

            // Increase the Count by 1
            Count += 1;
        }
    }
}
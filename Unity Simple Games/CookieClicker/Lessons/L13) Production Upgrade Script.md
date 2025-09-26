# L13) Production Upgrade Script

This lesson teaches how to make a script for the Production Upgrade

## Remember, What is a Script?

A Script is a Component which lets you customize how the Game Object works.

## Make a Script for the Production Upgrade

1) Select the Production Upgrade Object in the **Hierarchy**

2) Click **Add Component** in the **Inspector**

3) Select **New Script >** and name it "ProductionUpgradeCode"

4) Double-Click the Script to Open it

## Time to Code! First we need to add these Values

* **Cost** (Float/Decimal Number)

* **Boost** (Float/Decimal Number)

* **Count** (Integer Number)

## Since we want to SEE and EDIT these values they need to be PUBLIC

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
    }

## Next we need to set some Default Values for the Production Upgrade

1) Return to Unity, and look for the ProductionUpgradeCode Component in the Inspector

2) Change the numbers for the Cost, Boost, and Count

#### Here's an Example:

    Cost: 100
    Boost: 1
    Count: 0

## These are called VARIABLES!

Variables store information or values.

## Next we need to add a Purchase Function (Reopen the ProductionUpgradeCode Script)
    
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

## Final Script (we can leave the start and update function empty)

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

## Great! Now we need the Button to use the Purchase function when we click on it

1) Select the Production Upgrade Object in the **Hierarchy**

2) Look for the Button Component in the **Inspector**

3) Click the **+** button under the **On Click() Event Box**

4) Click and Drag the Production Upgrade Object from the Hierarchy into the Object Field

5) Click on the Drop-Down labeled "No Function"

6) Select **ProductionUpgradeCode >** and then select **Purchase()**

## Now test your game!

### If you have enough Total Cookies, you should be able to purchase the Production Upgrade

### Since we used the Cookie Manager, its variables will update in correctly
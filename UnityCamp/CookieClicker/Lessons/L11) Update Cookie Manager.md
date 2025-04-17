# L11) Update the Cookie Manager Object

Before we can produce Cookies every second, we need to update the Cookie Manager Script

## Open the Cookie Manager Script in the Cookie Manager Object

1. Select the **Cookie Manager Object** in the Hierarchy
   
3. Double-Click the **Cookie Manager** Script in the **Inspector**

## Open the Script and fix the Update Function

### // Update is called once per frame
    private void Update()
    {
        // Increase cookies based on cookies per second
        Timer += Time.deltaTime;
        
        // Check if 1 second has passed
        if (Timer >= 1)
        {
            // Add cookies to total and reset timer
            TotalCookies += CookiesPerSecond;

            // Reset the Timer to 0
            Timer = 0;
        }
    }

## Final Script

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class CookieManager : MonoBehaviour
    {
        // Singleton instance
        public static CookieManager Instance { get; private set; }

        // Public static properties
        public static float TotalCookies { get; set; }
        public static float CookiesPerSecond { get; set; }
        public static float CookiesPerClick { get; set; }

        // Private timer for passive income
        private float Timer;

        private void Awake()
        {
            // Singleton pattern implementation
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        private void Update()
        {
            // Increase cookies based on cookies per second
            Timer += Time.deltaTime;
            
            // Check if 1 second has passed
            if (Timer >= 1)
            {
                // Add cookies to total and reset timer
                TotalCookies += CookiesPerSecond;

                // Reset the Timer to 0
                Timer = 0;
            }
        }
    }

## Perfect! Now your Total Cookies will update every second for Production
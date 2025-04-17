# L1) Create the Cookie Manager Object

Before we start clicking for Cookies, we need **something** to keep track of:

1. **Total Cookies**

2. **Total Cookies Per Click**

3. **Total Cookies Per Second**

## Use an Empty Game Object for the Cookie Manager

In the **Hierarchy**, add an Empty Game Object and name it "Cookie Manager"

- Create Empty

## Add the Cookie Manager Script 

1. Select the **Cookie Manager Object**
   
2. Click **Add Component** in the **Inspector**

3. Select the **Cookie Manager** Script

## Open the Script and Fix the Code! (Start Function is Missing)

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

### // Start is called before the first frame update
    private void Start()
    {
        // Set default values
        TotalCookies = 0;
        CookiesPerSecond = 0;
        CookiesPerClick = 1;
        Timer = 0;
    }

}

## Good Job! Return to Unity and make sure it does not give any Errors. 
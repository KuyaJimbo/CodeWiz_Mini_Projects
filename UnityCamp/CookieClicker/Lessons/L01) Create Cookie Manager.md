# L1) Create the Cookie Manager Object

Before we start clicking for Cookies, we need **something** to keep track of:

1. **Total Cookies**

2. **Total Cookies Per Click**

3. **Total Cookies Per Second**

## Use an Empty Game Object for the Cookie Manager

In the **Hierarchy**, add an Empty Game Object and name it "Cookie Manager"

- Create Empty

## In the Inspector notice 1 COMPONENTS have been created

**Transform**

- Controls WHERE the Triangle Game Object is

## Add the Cookie Manager Script 

1. Select the **Cookie Manager Object**
   
2. Click **Add Component** in the **Inspector**

3. Select the **Cookie Manager** Script

## Open the Script and Fix the Code!

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CookieManager : MonoBehaviour

{

$\qquad$
$\qquad$// Singleton instance

$\qquad$
$\qquad$public static CookieManager Instance { get; private set; }

$\qquad$
$\qquad$// Public static properties

$\qquad$
$\qquad$public static float TotalCookies { get; set; }

$\qquad$
$\qquad$public static float CookiesPerSecond { get; set; }

$\qquad$
$\qquad$public static float CookiesPerClick { get; set; }

$\qquad$
$\qquad$// Private timer for passive income

$\qquad$
$\qquad$private float Timer;

$\qquad$
$\qquad$private void Awake()

$\qquad$
$\qquad${

$\qquad$
$\qquad$// Singleton pattern implementation

$\qquad$
$\qquad$if (Instance != null && Instance != this)

$\qquad$
$\qquad${

$\qquad$
$\qquad$$\qquad$
$\qquad$Destroy(gameObject);

$\qquad$
$\qquad$$\qquad$
$\qquad$return;

$\qquad$
$\qquad$}

$\qquad$
$\qquad$Instance = this;

$\qquad$
$\qquad$DontDestroyOnLoad(gameObject);

$\qquad$
$\qquad$}

### // Start is called before the first frame update
    private void Start()
    {
        // Set default values
        TotalCookies = 0f;
        CookiesPerSecond = 0f;
        CookiesPerClick = 1f;
        Timer = 0f;
    }

}

## Good Job! Return to Unity and make sure it does not give any Errors. 

### // Update is called once per frame
    private void Update()
    {
        // Increase cookies based on cookies per second
        Timer += Time.deltaTime;

        // If the timer reaches 1 second
        if (Timer >= 1f)
        {
            // Increase Total Cookies by Cookies Per Second
            TotalCookies += CookiesPerSecond;
            
            // Reset the Timer back to 0
            Timer = 0f;
        }
    }
}
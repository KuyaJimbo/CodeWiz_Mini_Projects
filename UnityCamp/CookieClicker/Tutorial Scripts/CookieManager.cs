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

    // Start is called before the first frame update
    private void Start()
    {
        // Set default values
        // Set TotalCookies = 0;
        TotalCookies = 0f;

        // SET CookiesPerSecond = 0;


        // SET CookiesPerClick = 1;
        

        // SET Timer = 0;
        

    }

    // Update is called once per frame
    private void Update()
    {
        // Increase cookies based on cookies per second
        Timer += Time.deltaTime;

        // If the timer reaches 1 second
        if (Timer >= 1f)
        {
            // Increase Total Cookies by Cookies Per Second
            // TotalCookies += CookiesPerSecond;

            
            // Reset the Timer back to 0
            // Timer = 0;

        }
    }
}
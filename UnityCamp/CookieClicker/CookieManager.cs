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

    private void Start()
    {
        // Initialize values
        TotalCookies = 0f;
        CookiesPerSecond = 0f;
        CookiesPerClick = 1f;
        Timer = 0f;
    }

    private void Update()
    {
        // Increase cookies based on cookies per second
        Timer += Time.deltaTime;
        
        if (Timer >= 1f)
        {
            TotalCookies += CookiesPerSecond;
            Timer -= 1f; // Subtract instead of resetting to 0 to maintain precision
            Debug.Log("Total Cookies: " + TotalCookies);
        }
    }
}
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance; // Singleton pattern
    
    [SerializeField] private int startingCoins = 100;
    [SerializeField] private Text coinsText;
    
    private int currentCoins;
    
    void Awake()
    {
        // Singleton setup
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    void Start()
    {
        currentCoins = startingCoins;
        UpdateUI();
    }
    
    public bool SpendCoins(int amount)
    {
        if (currentCoins >= amount)
        {
            currentCoins -= amount;
            UpdateUI();
            return true;
        }
        return false;
    }
    
    public void AddCoins(int amount)
    {
        currentCoins += amount;
        UpdateUI();
    }
    
    private void UpdateUI()
    {
        if (coinsText != null)
        {
            coinsText.text = "Coins: " + currentCoins;
        }
    }
    
    public int GetCurrentCoins()
    {
        return currentCoins;
    }
}
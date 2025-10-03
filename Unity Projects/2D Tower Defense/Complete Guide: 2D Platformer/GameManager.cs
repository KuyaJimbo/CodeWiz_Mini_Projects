using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    [Header("Base Health")]
    [SerializeField] private int maxBaseHealth = 20;
    [SerializeField] private Text healthText;
    
    [Header("UI")]
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject victoryPanel;
    
    private int currentHealth;
    
    void Awake()
    {
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
        currentHealth = maxBaseHealth;
        UpdateHealthUI();
        
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
        if (victoryPanel != null) victoryPanel.SetActive(false);
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);
        UpdateHealthUI();
        
        if (currentHealth <= 0)
        {
            GameOver();
        }
    }
    
    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Base Health: " + currentHealth;
        }
    }
    
    void GameOver()
    {
        Debug.Log("Game Over!");
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        Time.timeScale = 0f; // Pause game
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
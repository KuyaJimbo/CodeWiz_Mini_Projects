using UnityEngine;

public class TowerPlacer : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private int towerCost = 50;
    [SerializeField] private float placementRange = 3f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private GameObject placementPreview;
    
    private GameObject previewInstance;
    private bool canPlace;
    
    void Start()
    {
        // Create preview
        if (placementPreview != null)
        {
            previewInstance = Instantiate(placementPreview);
            previewInstance.SetActive(false);
        }
    }
    
    void Update()
    {
        HandleTowerPlacement();
    }
    
    void HandleTowerPlacement()
    {
        // Get mouse position in world space
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        // Check if within range of player
        float distanceToPlayer = Vector2.Distance(transform.position, mousePos);
        canPlace = distanceToPlayer <= placementRange;
        
        // Check if on ground
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.down, 0.5f, groundLayer);
        
        if (hit.collider != null && canPlace)
        {
            // Show preview
            if (previewInstance != null)
            {
                previewInstance.SetActive(true);
                previewInstance.transform.position = hit.point + Vector2.up * 0.5f;
                
                // Color preview based on affordability
                SpriteRenderer sr = previewInstance.GetComponent<SpriteRenderer>();
                if (sr != null)
                {
                    sr.color = ResourceManager.Instance.GetCurrentCoins() >= towerCost ? 
                        new Color(0, 1, 0, 0.5f) : new Color(1, 0, 0, 0.5f);
                }
            }
            
            // Place tower on click
            if (Input.GetMouseButtonDown(0))
            {
                PlaceTower(hit.point + Vector2.up * 0.5f);
            }
        }
        else
        {
            if (previewInstance != null)
                previewInstance.SetActive(false);
        }
    }
    
    void PlaceTower(Vector2 position)
    {
        if (ResourceManager.Instance.SpendCoins(towerCost))
        {
            Instantiate(towerPrefab, position, Quaternion.identity);
            Debug.Log("Tower placed!");
        }
        else
        {
            Debug.Log("Not enough coins!");
        }
    }
    
    void OnDrawGizmosSelected()
    {
        // Visualize placement range
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, placementRange);
    }
}
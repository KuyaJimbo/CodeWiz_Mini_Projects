using UnityEngine;

public class Tower : MonoBehaviour
{
    [Header("Tower Stats")]
    [SerializeField] private float range = 5f;
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private int damage = 20;
    
    [Header("Visuals")]
    [SerializeField] private Transform turretTransform; // The part that rotates
    [SerializeField] private bool shouldRotate = true;
    
    [Header("Projectile")]
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform firePoint;
    
    private Transform target;
    private float fireCountdown = 0f;
    
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }
    
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector2.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance && distanceToEnemy <= range)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        
        target = nearestEnemy != null ? nearestEnemy.transform : null;
    }
    
    void Update()
    {
        if (target == null)
            return;
        
        if (Vector2.Distance(transform.position, target.position) > range)
        {
            target = null;
            return;
        }
        
        // Rotate turret to face target
        if (shouldRotate && turretTransform != null)
        {
            Vector2 direction = target.position - turretTransform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            turretTransform.rotation = Quaternion.Euler(0, 0, angle - 90); // Adjust -90 based on sprite orientation
        }
        
        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        
        fireCountdown -= Time.deltaTime;
    }
    
    void Shoot()
    {
        if (projectilePrefab != null && firePoint != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
            Projectile projScript = projectile.GetComponent<Projectile>();
            
            if (projScript != null)
            {
                projScript.Seek(target, damage);
            }
        }
    }
    
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
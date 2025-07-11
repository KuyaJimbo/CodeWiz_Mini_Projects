using UnityEngine;

public class Launcher : MonoBehaviour
{
    [Header("Projectile Settings")]
    public GameObject projectilePrefab;  // Prefab with Rigidbody

    [Header("Launch Direction")]
    public Transform launchDirection;    // Empty object to aim from

    [Header("Launch Parameters")]
    public float launchForce = 10f;
    public float spawnInterval = 2f;

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            LaunchProjectile();
            timer = 0f;
        }
    }

    void LaunchProjectile()
    {
        // Instantiate at the launcher's position, or at launchDirection position
        GameObject projectile = Instantiate(projectilePrefab, launchDirection.position, launchDirection.rotation);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(launchDirection.forward * launchForce, ForceMode.Impulse);

    }
}

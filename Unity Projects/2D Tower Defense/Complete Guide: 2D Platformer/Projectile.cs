using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private bool rotateTowardsTarget = true;
    
    private Transform target;
    private int damage;
    
    public void Seek(Transform _target, int _damage)
    {
        target = _target;
        damage = _damage;
    }
    
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
        
        Vector2 direction = (target.position - transform.position).normalized;
        float distanceThisFrame = speed * Time.deltaTime;
        
        transform.position = Vector2.MoveTowards(transform.position, target.position, distanceThisFrame);
        
        // Rotate projectile to face direction
        if (rotateTowardsTarget)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        
        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            HitTarget();
        }
    }
    
    void HitTarget()
    {
        Enemy enemy = target.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        
        Destroy(gameObject);
    }
}
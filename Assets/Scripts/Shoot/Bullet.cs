using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            collision.collider.TryGetComponent<EnemyHealth>(out EnemyHealth enemyHealth);
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
        }
        
        Destroy(gameObject);
    }

}

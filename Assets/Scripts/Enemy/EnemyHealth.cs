using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int _health = 30;
    public void TakeDamage(int damage)
    {
        if (damage > 0)
        {
            Debug.Log("Good shot!");
            _health -= damage;
        }
        Death();
    }
    private void Death()
    {
        if (_health <= 0)
        {
            print("Enemy health <= 0");
            Destroy(this.gameObject);
        }
    }
}

using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int _health = 30;
    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.Log("Good shot!");
            _health -= damage;
        }
        else if(_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

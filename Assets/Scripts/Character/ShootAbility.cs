using UnityEngine;

public class ShootAbility : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 10f;

    public void ShootButton()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.TryGetComponent<Rigidbody>(out Rigidbody bulletRb);
        if (bulletRb == null)
        {
            print("No bullet rb");
        }

        bulletRb.velocity = firePoint.forward * bulletSpeed;
    }
}

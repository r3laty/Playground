using UnityEngine;

public class ShootAbility : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 10f;

    public void ShootButton()
    {
        Vector3 direction = firePoint.forward;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.LookRotation(direction));

        bullet.TryGetComponent<Rigidbody>(out Rigidbody bulletRb);
        if (bulletRb == null)
        {
            print("No bullet rb");
        }

        bulletRb.velocity = direction * bulletSpeed;
    }

}

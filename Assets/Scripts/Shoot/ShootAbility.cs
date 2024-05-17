using UnityEngine;

public class ShootAbility : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float bulletSpeed = 10f;
    [Space]
    [SerializeField] private Camera mainCam;

    public void ShootButton()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        bullet.transform.rotation *= Quaternion.Euler(90, 0, 0);

        bullet.TryGetComponent<Rigidbody>(out Rigidbody bulletRb);
        if (bulletRb == null)
        {
            print("No bullet rb");
        }

        Vector3 lookDirection = mainCam.transform.forward;

        bulletRb.velocity = lookDirection * bulletSpeed;
    }

}

using UnityEngine;

public class GunChanger : Choose
{
    private Transform _firePoint;
    private void Start()
    {
        _firePoint = GetComponent<Transform>();
    }
    public override void SetIndex(int index)
    {
        itemsToSpawn[_currentItemIndex].SetActive(false);

        _currentItemIndex = 0;

        base.SetIndex(index);
    }
    protected override void SpawnOnScene()
    {
        Transform pistolGunPoint = _firePoint;

        Vector3 m4GunPosition = new Vector3(0.3f, 0.6f, 1.8f);
        Vector3 ak47GunPoint = new Vector3(0.275999993f, 0.474999994f, 1.58599997f);
        Vector3 shotgunGunPoint = new Vector3(0.237000003f, 0.474999994f, 1.91299999f);
        Vector3 rpgGunPoint = new Vector3(0.237000003f, 0.433999985f, 2.00500011f);

        //switch (_currentItemIndex)
        //{
        //    case 0:
        //        _firePoint = pistolGunPoint;
        //        break;

        //    case 1:
        //        _firePoint.position = m4GunPosition;
        //        break;

        //    case 2:
        //        _firePoint.position = ak47GunPoint;
        //        break;

        //    case 3:
        //        _firePoint.position = shotgunGunPoint;
        //        break;

        //    case 4:
        //        _firePoint.position = rpgGunPoint;
        //        break;

        //}

        itemsToSpawn[_currentItemIndex].SetActive(true);
    }
}

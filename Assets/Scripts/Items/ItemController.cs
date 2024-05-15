using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject[] itemsToSpawn;

    private int _currentItemIndex;
    public void SetIndex(int index)
    {
        _currentItemIndex = index;
        SpawnOnScene();
    }
    private void SpawnOnScene()
    {
        var GO = Instantiate(itemsToSpawn[_currentItemIndex], transform.position, Quaternion.identity);
        _currentItemIndex = 0;
    }
}

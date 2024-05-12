using UnityEngine;

public class ItemController : MonoBehaviour
{

    [SerializeField] private int currentItemIndex;

    [SerializeField] private GameObject[] itemsToSpawn;

    public void SetIndex(int index)
    {
        currentItemIndex = index;
        SpawnOnScene();
    }
    private void SpawnOnScene()
    {
        var GO = Instantiate(itemsToSpawn[currentItemIndex], transform.position, Quaternion.identity);
        currentItemIndex = 0;
    }
}

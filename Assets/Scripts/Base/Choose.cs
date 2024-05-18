using UnityEngine;

public class Choose : MonoBehaviour
{
    [SerializeField] protected GameObject[] itemsToSpawn;

    protected int _currentItemIndex;
    public virtual void SetIndex(int index)
    {
        _currentItemIndex = index;
        SpawnOnScene();
    }
    protected virtual void SpawnOnScene()
    {
        var GO = Instantiate(itemsToSpawn[_currentItemIndex], transform.position, Quaternion.identity);
        _currentItemIndex = 0;
    }

}

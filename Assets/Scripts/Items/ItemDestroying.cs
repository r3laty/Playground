using UnityEngine;

public class ItemDestroying : MonoBehaviour, IRaycastable
{
    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask itemLayer;

    private bool _isClicked;
    private void Update()
    {
        if (_isClicked)
        {
            Raycatsing();
            _isClicked = false;
        }
    }
    public void Raycatsing()
    {
        RaycastHit hit;
        var raycast = Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, itemLayer);
        if (raycast)
        {
            Destroy(hit.collider.gameObject);
        }
        else
        {
            Debug.Log("Object dosn't find");
        }
    }
    public void OnDeletFromSceneClick() => _isClicked = true;
}

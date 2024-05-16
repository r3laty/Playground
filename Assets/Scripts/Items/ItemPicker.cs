using UnityEngine;

public class ItemPicker : MonoBehaviour, IRaycastable
{
    [SerializeField] private Transform handTransform;

    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask itemLayer;
    [Space]
    [SerializeField] private Camera mainCam;

    private Transform _hitTransform = null;
    private Rigidbody _hitRb = null;
    private void Update()
    {
        if (ButtonHoldDetector.IsButtonHold)
        {
            Raycatsing();
        }
        else if (!ButtonHoldDetector.IsButtonHold)
        {
            _hitRb.useGravity = true;
            _hitRb = null;
            _hitTransform = null;
        }
    }
    public void Raycatsing()
    {

        RaycastHit hit;
        var raycast = Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, itemLayer);

        if (raycast)
        {
            hit.collider.TryGetComponent<Transform>(out _hitTransform);
            hit.collider.TryGetComponent<Rigidbody>(out _hitRb);

            _hitTransform.position = handTransform.position;
            _hitRb.velocity = Vector3.zero;
            _hitRb.useGravity = false;
            Debug.Log("Item chosen " + hit.collider.name);
        }
        else
        {
            Debug.Log("Item dont chosen");
        }
    }
}


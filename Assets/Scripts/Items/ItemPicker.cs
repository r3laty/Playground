using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] private Transform handTransform;

    [SerializeField] private float raycastDistance;
    [SerializeField] private LayerMask itemLayer;

    private Transform _hitTransform = null;
    private Rigidbody _hitRb = null;
    private void Update()
    {
        if (ButtonHeldDetector.IsButtonHold)
        {
            RaycastHit hit;
            var raycast = Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, itemLayer);

            if (raycast)
            {
                hit.collider.TryGetComponent<Transform>(out _hitTransform);
                hit.collider.TryGetComponent<Rigidbody>(out _hitRb);

                _hitRb.velocity = Vector3.zero;
                Debug.Log("Item chosen " + hit.collider.name);
            }
            else
            {
                Debug.Log("Item dont chosen");
            }
            if (_hitTransform != null)
            {
                _hitTransform.position = handTransform.position;
            }
        }
        _hitRb = null;
        _hitTransform = null;
    }
}


using UnityEngine;

public class TouchController : MonoBehaviour
{
    [SerializeField] private FixedTouchField fixedTouchField;
    [SerializeField] private CameraLook cameraLook;

    void Update()
    {
        cameraLook.LockAxis = fixedTouchField.TouchDistance;
    }
}

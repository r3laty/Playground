using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [HideInInspector]public Vector2 LockAxis;
    
    [SerializeField] private Transform playerBody;
    [SerializeField] private float sensivity = 40f;
    
    private float _xMove;
    private float _yMove;
    private float _xRotation;
    void Update()
    {
        _xMove = LockAxis.x * sensivity * Time.deltaTime;
        _yMove = LockAxis.y * sensivity * Time.deltaTime;
        _xRotation -= _yMove;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_xRotation,0,0);
        playerBody.Rotate(Vector3.up * _xMove);
    }
}

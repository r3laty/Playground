using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Joystick joystick;
    [SerializeField] private Camera cam;

    [SerializeField] private float speed = 6f;

    private Rigidbody _rb;
    
    private Vector3 _move;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = new Vector3(x, 0f, z).normalized;

        Vector3 forward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up).normalized;
        _move = Quaternion.LookRotation(forward) * move;
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _rb.velocity = _move * speed;
    }
}

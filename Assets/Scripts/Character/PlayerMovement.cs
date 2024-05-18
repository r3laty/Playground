using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5;


    [SerializeField] private Joystick joystick;
    [SerializeField] private Camera cam;

    [SerializeField] private float speed = 6f;

    private Rigidbody _rb;
    private bool _isPressed;
    private bool _isGrounded;
    private Vector3 _move;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = new Vector3(x, _rb.velocity.y, z);

        Vector3 forward = Vector3.ProjectOnPlane(cam.transform.forward, Vector3.up);
        _move = Quaternion.LookRotation(forward) * move;

        if (_isPressed && _isGrounded)
        {
            print($"is grounded {_isGrounded}");
            Jump();
            _isPressed = false;
        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        _rb.velocity = new Vector3(_move.x * speed, _move.y, _move.z * speed);
    }
    private void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void OnClick()
    {
        _isPressed = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;
            _isPressed = false;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }
}

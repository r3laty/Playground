using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.4f;

    private Rigidbody _rb; 
    private Vector3 _velocity;

    private bool _isPressed;
    private bool _isGrounded;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Jump()
    {
        _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
    public void OnClick()
    {
        Jump();
    }
}

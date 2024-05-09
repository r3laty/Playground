using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5;
    [SerializeField] private float gravity = -10;

    private CharacterController _controller;
    private Vector3 _velocity;

    private bool _isPressed;
    private bool _isGrounded;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (_isPressed)
        {
            _velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            _isPressed = false;
        }

        _velocity.y += gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);
    }
    public void Jump()
    {
        _isPressed = true;

        if (_isGrounded)
        {
        }
    }
}

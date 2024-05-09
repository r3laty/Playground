using UnityEngine;
[RequireComponent (typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float Movespeed = 5f;
    [SerializeField] private FixedJoystick joystick;

    private CharacterController _controller;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        _controller.Move(Move * Movespeed * Time.deltaTime);
    }
}

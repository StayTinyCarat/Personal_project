using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D _rb;
    private Vector2 _moveAmount;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rb.linearVelocityX = _moveAmount.x * movementSpeed;
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
        _moveAmount = (ctx.ReadValue<Vector2>());
    }
}

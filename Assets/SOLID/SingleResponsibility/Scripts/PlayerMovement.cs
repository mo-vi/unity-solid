using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float runSpeed;
    private PlayerInput _playerInput;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var newPlayerVelocity = new Vector2(_playerInput.Horizontal * runSpeed * Time.deltaTime, _rigidbody.velocity.y);
        _rigidbody.velocity = newPlayerVelocity;
    }
}

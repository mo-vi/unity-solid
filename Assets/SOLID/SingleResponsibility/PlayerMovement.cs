using UnityEngine;

namespace SingleResponsibility
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float jumpSpeed;
        [SerializeField] private new Rigidbody2D rigidbody;
        [SerializeField] private float runSpeed;
        private PlayerInput playerInput;

        void Start()
        {
            playerInput = GetComponent<PlayerInput>();
            rigidbody = GetComponent<Rigidbody2D>();

            GetComponent<PlayerInput>().OnJump += HandleJump;
        }

        void Update()
        {
            var newPlayerVelocity = new Vector2(playerInput.Horizontal * runSpeed * Time.deltaTime, rigidbody.velocity.y);
            rigidbody.velocity = newPlayerVelocity;
        }

        void HandleJump()
        {
            rigidbody.velocity += new Vector2(0.0f, jumpSpeed);
        }
    }
}

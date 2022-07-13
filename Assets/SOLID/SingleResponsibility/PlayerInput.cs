using System;
using UnityEngine;

namespace SingleResponsibility
{
    public class PlayerInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }

        public event Action OnAttack = delegate { };
        public event Action OnJump = delegate { };

        void Update()
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxis("Vertical");

            if (Input.GetButtonDown("Fire1"))
            {
                OnAttack();
            }

            if (Input.GetButtonDown("Jump"))
            {
                OnJump();
            }
        }
    }
}

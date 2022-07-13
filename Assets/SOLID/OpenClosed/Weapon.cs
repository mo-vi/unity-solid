using System;
using UnityEngine;

namespace OpenClosed
{
    public class Weapon : MonoBehaviour
    {
        /* This also can be made with an Interface, something like ILauncher with a Launch method */
        /* I left interfaces for the InterfaceSegregation principle. They won't be used here */
        public event Action OnShoot = delegate { };

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                OnShoot();
            }
        }
    }
}

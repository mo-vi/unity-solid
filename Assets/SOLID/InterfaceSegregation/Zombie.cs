using UnityEngine;

namespace InterfaceSegregation
{
    public class Zombie : MonoBehaviour, IHaveHealth, ITakeDamage
    {
        public float Health { get; private set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        void Update()
        {
            // Some AI logic
        }
    }
}

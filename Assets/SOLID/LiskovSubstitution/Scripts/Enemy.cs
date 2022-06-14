using UnityEngine;

namespace LiskovSubstitution
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int maxHealth = 100;

        private int currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public virtual void TakeDamage(int amount)
        {
            currentHealth -= amount;
        }
    }
}


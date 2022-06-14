using System;
using System.Linq;
using UnityEngine;

namespace LiskovSubstitution
{
    public class DealDamage : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                DealDamageToNearestEnemy();
            }
        }

        private void DealDamageToNearestEnemy()
        {
            var nearestEnemy = FindObjectsOfType<Enemy>().OrderBy(T => Vector2.Distance(transform.position, T.transform.position)).FirstOrDefault();
            
            nearestEnemy.TakeDamage(1);
        }
    }
}


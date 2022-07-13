using UnityEngine;

namespace DependencyInversion
{
    public class AIController : MonoBehaviour, IUseInput
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }

        void Update()
        {
            Horizontal = Random.Range(-5, 5);
            Vertical = Random.Range(0, 0.2f);
        }
    }
}


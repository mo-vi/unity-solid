using UnityEngine;

namespace DependencyInversion
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;
        private IUseInput iUseInput;

        void Start()
        {
            iUseInput = GetComponent<IUseInput>();
        }

        void Update()
        {
            var x = iUseInput.Horizontal;
            var z = iUseInput.Vertical;

            var movement = new Vector3(x, 0, z).normalized * speed * Time.deltaTime;

            transform.Translate(movement);
        }
    }
}

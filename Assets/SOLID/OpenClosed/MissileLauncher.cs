using UnityEngine;

namespace OpenClosed
{
    [RequireComponent(typeof(Weapon))]
    public class MissileLauncher : MonoBehaviour
    {
        [SerializeField] Missile missilePrefab;
        Transform target;

        void Start()
        {
            GetComponent<Weapon>().OnShoot += HandleShooting;
        }

        void HandleShooting()
        {
            var missile = Instantiate(missilePrefab);
            
            /* Missile handling */
            // Set target
            // Then some logic like: if (target) missile.HomingMovement(target)
        }
    }
}

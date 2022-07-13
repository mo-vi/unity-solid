using UnityEngine;

namespace OpenClosed
{
    [RequireComponent(typeof(Weapon))]
    public class BulletLauncher : MonoBehaviour
    {
        [SerializeField] Bullet bulletPrefab;

        void Start()
        {
            GetComponent<Weapon>().OnShoot += HandleShooting;
        }

        void HandleShooting()
        {
            var bullet = Instantiate(bulletPrefab);

            /* Bullet handling */
            // Some logic like bullet.rigidbody.AddForce(transform.forward * bullet.velocity) taking into account that some bullets may travel faster
        }
    }
}

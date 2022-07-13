using UnityEngine;

namespace SingleResponsibility
{
    public class PlayerSpellCaster : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D spellPrefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float spellForce = 1500.0f;

        void Start()
        {
            GetComponent<PlayerInput>().OnAttack += HandleAttack;
        }

        void HandleAttack()
        {
            var projectile = Instantiate(spellPrefab, spawnPoint.position, spawnPoint.rotation);
            projectile.AddForce(projectile.transform.right * spellForce);
        }
    }
}

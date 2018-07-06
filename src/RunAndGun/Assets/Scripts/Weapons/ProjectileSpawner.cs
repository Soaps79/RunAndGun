using QGame;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    public class ProjectileSpawner : QScript
    {
        [SerializeField] private Projectile _projectilePrefab;

        public void Spawn()
        {
            var proj = Instantiate(_projectilePrefab, this.transform.position, this.transform.rotation);
            var rigidBody = proj.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(transform.up * 1000);
        }
    }
}
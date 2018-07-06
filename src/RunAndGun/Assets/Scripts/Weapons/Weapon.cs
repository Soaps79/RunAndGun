using QGame;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    [RequireComponent(typeof(ProjectileSpawner))]
    public class Weapon : QScript
    {
        [SerializeField] private float _fireDelay;
        private float _elapsed;
        [SerializeField] private bool _isOnCooldown;
        private ProjectileSpawner _projectileSpawner;

        void Start()
        {
            _projectileSpawner = GetComponent<ProjectileSpawner>();
            OnEveryUpdate += UpdateCooldown;
        }

        private void UpdateCooldown()
        {
            if (!_isOnCooldown)
                return;

            _elapsed += Time.deltaTime;
            if (_elapsed > _fireDelay)
                _isOnCooldown = false;
        }

        public bool TryFire()
        {
            if(_isOnCooldown)
                return false;

            Fire();
            return true;
        }

        private void Fire()
        {
            // fire logic
            _projectileSpawner.Spawn();

            if (_fireDelay > 0)
            {
                _elapsed = 0;
                _isOnCooldown = true;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.WeaponSystem
{
    public class ProjectileWeapon : MonoBehaviour, IWeapon
    {
        [SerializeField]
        private GameObject _projectile;
        [SerializeField]
        private float _shootFrequency;
        [SerializeField]
        private float _damage;
        public float Damage
        {
            get => _damage;
            set => _damage = value;
        }
        
        private float _timer = 0;

        public void Shoot()
        {
            _projectile.transform.localScale = new Vector3(
                    _projectile.transform.localScale.x * (tag == "Enemy"?-1:1), 
                    _projectile.transform.localScale.y, 
                    0);
            Instantiate(_projectile,transform);
        }

        private void Update()
        {
            _timer += Time.deltaTime;
            if (_timer > _shootFrequency)
            {
                Shoot();
                _timer = 0;
            }
        }
    }
}
    

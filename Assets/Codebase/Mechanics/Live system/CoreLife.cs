using System;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public class CoreLife : MonoBehaviour, ILife
    {
        public static event Action DeathEvent;

        [SerializeField]
        private float _maxHP;
        private float _currentHP;
        public float MaxHP
        {
            get => _maxHP;
        }
        public float CurrentHP
        {
            get => _currentHP;
            set => _currentHP = value;
        }

        public virtual void Start()
        {
            _currentHP = _maxHP;
        }
        public void TakeDamage(float damage)
        {
            CurrentHP -= damage;
            if (CurrentHP <= 0) 
            {
                Die();
            }
        }
        public void Die()
        {
            if(tag=="Player")
                DeathEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
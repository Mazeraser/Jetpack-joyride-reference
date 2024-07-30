using System;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public interface ILife
    {
        public static event Action DeathEvent;

        float MaxHP { get; }
        float CurrentHP { get; set; }
        void TakeDamage(float damage);
        void Die();
    }
}
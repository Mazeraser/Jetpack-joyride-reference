using Assets.Codebase.Mechanics.ControllSystem;
using Assets.Codebase.Mechanics.LiveSystem;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public class PlayerLife : CoreLife
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Obstacle")&& collision.gameObject.GetComponent<ILife>()!=null)
            {
                TakeDamage(collision.gameObject.GetComponent<ILife>().MaxHP); 
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.CompareTag("Projectile"))
            {
                int damage = (int)collision.gameObject.GetComponent<ProjectileLife>().CurrentHP;
                collision.gameObject.GetComponent<ProjectileLife>().TakeDamage(CurrentHP);
                TakeDamage(damage);
            }
        }
    }
}
    

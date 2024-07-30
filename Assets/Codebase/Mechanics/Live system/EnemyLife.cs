using Assets.Codebase.Mechanics.ControllSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{

    public class EnemyLife : CoreLife
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Projectile"))
            {
                int damage = (int)collision.gameObject.GetComponent<ProjectileLife>().CurrentHP;
                collision.gameObject.GetComponent<ProjectileLife>().TakeDamage(CurrentHP);
                TakeDamage(damage);
            }
        }
    }
}
using System;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public class PlayerLife : MonoBehaviour, ILife
    {
        public static event Action DeathEvent;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Obstacle")
            {
                DeathEvent?.Invoke();
            }
        }
    }
}
    

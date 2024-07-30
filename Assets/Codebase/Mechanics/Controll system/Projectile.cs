using System.Collections;
using System.Collections.Generic;
using Assets.Codebase.Mechanics.MoveSystem;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ControllSystem
{
    [RequireComponent(typeof(Walk))]
    public class Projectile : MonoBehaviour, IControllable
    {
        public void ControllMove(Vector2 velocity)
        {
            GetComponent<Walk>().Turn(velocity.normalized);
        }

        private void Start()
        {
            transform.parent = null;
        }
        private void Update()
        {
            ControllMove(new Vector2 (1, 0));
        }
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public class ProjectileLife : CoreLife
    {
        [SerializeField]
        private float _lifeTime;
        private float _timer = 0;

        private void Update()
        {
            _timer += Time.deltaTime;
            if (_timer >= _lifeTime)
                Destroy(this.gameObject);
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Obstacle")&&other.gameObject.GetComponent<ILife>()==null)
                Destroy(this.gameObject);
        }
    }
}
    

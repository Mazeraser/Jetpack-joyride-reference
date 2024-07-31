using Assets.Codebase.Mechanics.ShopSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Codebase.Mechanics.ResourceCollector
{

    public class MoneyCollector : MonoBehaviour, ICollector
    {
        [SerializeField]
        private ResourceStorage _storage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Collect(1);
                Destroy(this.gameObject);
            }
        }

        public void Collect(int count)
        {
            _storage.Coins += count;
        }
    }
}
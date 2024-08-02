using Assets.Codebase.Mechanics.ShopSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Assets.Codebase.Mechanics.ResourceCollector
{
    public class DiamondsCollictor : MonoBehaviour, ICollector
    {
        public void Collect(ref int storage,int count)
        {
            storage += count;
            Destroy(this.gameObject);
        }
    }
}
    

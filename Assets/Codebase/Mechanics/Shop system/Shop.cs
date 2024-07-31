using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem
{
    public class Shop : MonoBehaviour
    {
        public ResourceStorage resourceStorage;

        public Vehicle[] VehicleList;
        public Weapon[] WeaponList;

        public bool Spend(int coins)
        {
            if (resourceStorage.Coins >= coins)
            {
                resourceStorage.Coins -= coins;
                return true;
            }
            return false;
        }
    }
}
    

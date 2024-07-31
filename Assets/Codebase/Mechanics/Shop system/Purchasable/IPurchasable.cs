using System;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem.Purchasable
{
    public interface IPurchasable 
    {
        int Cost { get; }
        string ItemName { get; }
        bool Bought { get; set; }
        void Purchase();
    }
}
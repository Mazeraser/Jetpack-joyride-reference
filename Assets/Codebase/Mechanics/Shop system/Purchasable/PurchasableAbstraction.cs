using UnityEngine;
using Assets.Codebase.Mechanics.ControllSystem;
using System;

namespace Assets.Codebase.Mechanics.ShopSystem.Purchasable
{
    public abstract class PurchasableAbstraction : IPurchasable
    {
        public static event Action PurchasedEvent;

        [SerializeField]
        private int _cost;
        public int Cost
        {
            get => _cost;
        }

        [SerializeField]
        private string _itemName;
        public string ItemName
        {
            get => _itemName;
        }

        [SerializeField]
        private bool _bought = false;
        public bool Bought
        {
            get => _bought;
            set => _bought = value;
        }
        public Player ForCharacter;
        public virtual void Purchase() { }
    }
}
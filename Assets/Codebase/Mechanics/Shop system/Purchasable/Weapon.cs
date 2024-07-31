using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using Assets.Codebase.Mechanics.ShopSystem.Section;
using Assets.Codebase.Mechanics.WeaponSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem.Purchasable
{
    [Serializable]
    public sealed class Weapon : PurchasableAbstraction
    {
        [SerializeField]
        private WeaponSection _section;

        [SerializeField]
        private GameObject _weapon;
        public GameObject WeaponObject => _weapon;

        public override void Purchase()
        {
            if (Bought)
                _section.Equip(this);
            else
                _section.Buy(this);
        }
    }
}
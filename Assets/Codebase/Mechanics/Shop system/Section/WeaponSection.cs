using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject.Asteroids;

namespace Assets.Codebase.Mechanics.ShopSystem.Section
{
    public class WeaponSection : SectionAbstract, ISection<Weapon>
    {
        public void Buy(Weapon item)
        {
            if (_shop.Spend(item.Cost))
            {
                Debug.Log($"Weapon {item.ItemName} is purchased");
                item.Bought = true;
                item.ForCharacter.SetNewWeapon(item);
            }
        }
        public void Equip(Weapon item)
        {
            item.ForCharacter.SetNewWeapon(item);
        }
    }
}
    
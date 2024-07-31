using Assets.Codebase.Mechanics.ControllSystem;
using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem.Section
{
    public class VehicleSection : SectionAbstract, ISection<Vehicle>
    {
        public void Buy(Vehicle item)
        {
            if (_shop.Spend(item.Cost))
            {
                Debug.Log($"Vehicle {item.ItemName} is purchased");
                item.Bought = true;
                item.ForCharacter.SetNewVehicle(item);
            }
        }
        public void Equip(Vehicle item) 
        {
            item.ForCharacter.SetNewVehicle(item);
        }
    }
}
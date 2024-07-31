using Assets.Codebase.Mechanics.ShopSystem.Section;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Codebase.Mechanics.ShopSystem.Purchasable
{
    [Serializable]
    public sealed class Vehicle : PurchasableAbstraction
    {
        [SerializeField]
        private VehicleSection _section;

        [SerializeField]
        private float _vehiclePower;
        public float VehiclePower => _vehiclePower;

        [SerializeField]
        private Sprite _vehicleImage;
        public Sprite VehicleImage => _vehicleImage;

        public override void Purchase()
        {
            if (Bought)
                _section.Equip(this);
            else
                _section.Buy(this);
        }
    }
}
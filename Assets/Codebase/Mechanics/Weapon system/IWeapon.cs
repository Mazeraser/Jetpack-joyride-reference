using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.WeaponSystem
{
    public interface IWeapon
    {
        float ShootFrequency { get; set; }
        void Shoot();
    }
}
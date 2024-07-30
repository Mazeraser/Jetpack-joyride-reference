using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.WeaponSystem
{
    public interface IWeapon
    {
        float Damage {  get; set; }
        void Shoot();
    }
}
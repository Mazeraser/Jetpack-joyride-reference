using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem.Section
{
    public interface ISection<T>
    {
        void Buy(T item);
        void Equip(T item);
    }
}
    

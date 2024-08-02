using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ResourceCollector
{
    public interface ICollector
    {
        void Collect(ref int storage, int count); 
    }
}
    
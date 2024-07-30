using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.GeneratorSystem
{
    public class GeneratedPoint : MonoBehaviour
    {
        public static event Action<Transform> NewPointGeneratedEvent;

        public void Start()
        {
            NewPointGeneratedEvent?.Invoke(transform);
        }
    }
}
    

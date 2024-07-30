using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.GeneratorSystem
{
    public interface IGenerator
    {
        void Generate(Transform generate_position);
    }
}
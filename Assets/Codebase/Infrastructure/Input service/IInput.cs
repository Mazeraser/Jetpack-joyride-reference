using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Infrastructure.InputService
{
    public interface IInput
    {
        float JumpValue();

        void Activate();
        void Deactivate();
    }
}
    

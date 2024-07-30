using Codebase.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using Zenject;

namespace Assets.Codebase.Infrastructure.InputService
{
    public class KeyboardInput : IInput, IInitializable, IDisposable
    {
        public event Action<Vector2> JumpPerformed;

        private Main inputActions;

        public KeyboardInput()
        {
            inputActions = new Main();
        }

        public void Initialize()
        {
            Activate();
        }
        public void Dispose()
        {
            Deactivate();
        }

        public void Activate()
        {
            inputActions.Enable();
        }
        public void Deactivate()
        {
            inputActions.Disable();
        }

        public float JumpValue()
        {
            return inputActions.Move.Jump.ReadValue<float>();
        }
    }
}
    

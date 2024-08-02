//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Codebase/InputSystem/Main.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Codebase.InputSystem
{
    public partial class @Main: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Main()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""3903a49b-db85-49b4-8c78-57e4dedf90e8"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""019504c1-a70f-467f-ab36-311dc6601b3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""937ba618-8c7f-447c-8e18-7fe5f3ac802b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b6054136-a761-44da-8399-5f547b842951"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""913f7d5a-c448-4415-bcc4-7a7d4c9e96fd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Move
            m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
            m_Move_Jump = m_Move.FindAction("Jump", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Move
        private readonly InputActionMap m_Move;
        private List<IMoveActions> m_MoveActionsCallbackInterfaces = new List<IMoveActions>();
        private readonly InputAction m_Move_Jump;
        public struct MoveActions
        {
            private @Main m_Wrapper;
            public MoveActions(@Main wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Move_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Move; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
            public void AddCallbacks(IMoveActions instance)
            {
                if (instance == null || m_Wrapper.m_MoveActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MoveActionsCallbackInterfaces.Add(instance);
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }

            private void UnregisterCallbacks(IMoveActions instance)
            {
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
            }

            public void RemoveCallbacks(IMoveActions instance)
            {
                if (m_Wrapper.m_MoveActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMoveActions instance)
            {
                foreach (var item in m_Wrapper.m_MoveActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MoveActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MoveActions @Move => new MoveActions(this);
        private int m_MouseSchemeIndex = -1;
        public InputControlScheme MouseScheme
        {
            get
            {
                if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
                return asset.controlSchemes[m_MouseSchemeIndex];
            }
        }
        public interface IMoveActions
        {
            void OnJump(InputAction.CallbackContext context);
        }
    }
}

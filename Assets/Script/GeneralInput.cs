// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/GeneralInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralInput"",
    ""maps"": [
        {
            ""name"": ""DefenderArea"",
            ""id"": ""ebc9a58c-5ee2-461f-a1dc-71daa4318a70"",
            ""actions"": [
                {
                    ""name"": ""DefenderSpawn"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b6d984aa-a6b8-4304-b2f6-b894900d67a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""65a7543e-702c-482e-bae7-ee9fe689ab5b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DefenderSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4c2424b-f173-4c82-93bd-bbb6b0c03ed2"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DefenderSpawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefenderArea
        m_DefenderArea = asset.FindActionMap("DefenderArea", throwIfNotFound: true);
        m_DefenderArea_DefenderSpawn = m_DefenderArea.FindAction("DefenderSpawn", throwIfNotFound: true);
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

    // DefenderArea
    private readonly InputActionMap m_DefenderArea;
    private IDefenderAreaActions m_DefenderAreaActionsCallbackInterface;
    private readonly InputAction m_DefenderArea_DefenderSpawn;
    public struct DefenderAreaActions
    {
        private @GeneralInput m_Wrapper;
        public DefenderAreaActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @DefenderSpawn => m_Wrapper.m_DefenderArea_DefenderSpawn;
        public InputActionMap Get() { return m_Wrapper.m_DefenderArea; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefenderAreaActions set) { return set.Get(); }
        public void SetCallbacks(IDefenderAreaActions instance)
        {
            if (m_Wrapper.m_DefenderAreaActionsCallbackInterface != null)
            {
                @DefenderSpawn.started -= m_Wrapper.m_DefenderAreaActionsCallbackInterface.OnDefenderSpawn;
                @DefenderSpawn.performed -= m_Wrapper.m_DefenderAreaActionsCallbackInterface.OnDefenderSpawn;
                @DefenderSpawn.canceled -= m_Wrapper.m_DefenderAreaActionsCallbackInterface.OnDefenderSpawn;
            }
            m_Wrapper.m_DefenderAreaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DefenderSpawn.started += instance.OnDefenderSpawn;
                @DefenderSpawn.performed += instance.OnDefenderSpawn;
                @DefenderSpawn.canceled += instance.OnDefenderSpawn;
            }
        }
    }
    public DefenderAreaActions @DefenderArea => new DefenderAreaActions(this);
    public interface IDefenderAreaActions
    {
        void OnDefenderSpawn(InputAction.CallbackContext context);
    }
}

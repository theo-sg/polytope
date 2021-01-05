// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""626572a2-2f69-4c5a-b6ab-650820a071fc"",
            ""actions"": [
                {
                    ""name"": ""AD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""823e8466-6929-4c12-a566-4692358741a2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Value"",
                    ""id"": ""05ca8b32-e8dd-4b25-af99-27e1fa11e362"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""HoldSpace"",
                    ""type"": ""Value"",
                    ""id"": ""366ae7e5-7794-4343-bd7d-0ddc30cabe3f"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f85d14ca-dcf2-4b8a-9ebc-0fb5c58d6b81"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f24c318b-e717-435d-b67e-173d3166f657"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d512517c-c303-4e7e-a312-e264f238ee43"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""AD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c5acae1c-0890-4e30-892d-80892b7c08e4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a90e9148-376e-4331-bc4d-61e22d5c6471"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HoldSpace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_AD = m_Movement.FindAction("AD", throwIfNotFound: true);
        m_Movement_Space = m_Movement.FindAction("Space", throwIfNotFound: true);
        m_Movement_HoldSpace = m_Movement.FindAction("HoldSpace", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_AD;
    private readonly InputAction m_Movement_Space;
    private readonly InputAction m_Movement_HoldSpace;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @AD => m_Wrapper.m_Movement_AD;
        public InputAction @Space => m_Wrapper.m_Movement_Space;
        public InputAction @HoldSpace => m_Wrapper.m_Movement_HoldSpace;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @AD.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @AD.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @AD.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @Space.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSpace;
                @HoldSpace.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHoldSpace;
                @HoldSpace.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHoldSpace;
                @HoldSpace.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHoldSpace;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AD.started += instance.OnAD;
                @AD.performed += instance.OnAD;
                @AD.canceled += instance.OnAD;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @HoldSpace.started += instance.OnHoldSpace;
                @HoldSpace.performed += instance.OnHoldSpace;
                @HoldSpace.canceled += instance.OnHoldSpace;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnAD(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnHoldSpace(InputAction.CallbackContext context);
    }
}

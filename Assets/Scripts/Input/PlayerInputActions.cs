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
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""ac7370c2-53af-4c72-aa53-98bd24e0e3a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""823e8466-6929-4c12-a566-4692358741a2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Value"",
                    ""id"": ""137e9b14-da80-4dff-b4fe-abc2528f5d6f"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": ""Press""
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
                },
                {
                    ""name"": """",
                    ""id"": ""94a23811-3fe0-40ea-8eb2-0672440f6319"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8fd1b8c-dbd2-4552-976d-68091c19b3d2"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tool"",
            ""id"": ""a2151f15-533c-4f26-bfa4-83c599a33fb6"",
            ""actions"": [
                {
                    ""name"": ""LMB"",
                    ""type"": ""Button"",
                    ""id"": ""0f56ca5e-d6b0-4405-b974-fd70c2ed9126"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RMB"",
                    ""type"": ""Button"",
                    ""id"": ""09f1ab46-3d26-4937-a1cf-03aa7b1c8ee0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MMB"",
                    ""type"": ""Button"",
                    ""id"": ""a5f7a015-abd5-4cb8-9be6-9711864be506"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ae0aa89b-1f3a-48e0-b695-a87e094263aa"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35a829d0-8454-4d2d-afa7-8de0702449d0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d0d0929-767f-4d1c-8ad0-d830c4fc8ce5"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e85b17c-76f6-416d-856e-0debab557e99"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MMB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03e2e5a1-6eec-4e53-86c9-4a633644281d"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
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
        m_Movement_MousePos = m_Movement.FindAction("MousePos", throwIfNotFound: true);
        m_Movement_AD = m_Movement.FindAction("AD", throwIfNotFound: true);
        m_Movement_S = m_Movement.FindAction("S", throwIfNotFound: true);
        m_Movement_Space = m_Movement.FindAction("Space", throwIfNotFound: true);
        m_Movement_HoldSpace = m_Movement.FindAction("HoldSpace", throwIfNotFound: true);
        // Tool
        m_Tool = asset.FindActionMap("Tool", throwIfNotFound: true);
        m_Tool_LMB = m_Tool.FindAction("LMB", throwIfNotFound: true);
        m_Tool_RMB = m_Tool.FindAction("RMB", throwIfNotFound: true);
        m_Tool_MMB = m_Tool.FindAction("MMB", throwIfNotFound: true);
        m_Tool_Scroll = m_Tool.FindAction("Scroll", throwIfNotFound: true);
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
    private readonly InputAction m_Movement_MousePos;
    private readonly InputAction m_Movement_AD;
    private readonly InputAction m_Movement_S;
    private readonly InputAction m_Movement_Space;
    private readonly InputAction m_Movement_HoldSpace;
    public struct MovementActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovementActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Movement_MousePos;
        public InputAction @AD => m_Wrapper.m_Movement_AD;
        public InputAction @S => m_Wrapper.m_Movement_S;
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
                @MousePos.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMousePos;
                @AD.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @AD.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @AD.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnAD;
                @S.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnS;
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
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @AD.started += instance.OnAD;
                @AD.performed += instance.OnAD;
                @AD.canceled += instance.OnAD;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
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

    // Tool
    private readonly InputActionMap m_Tool;
    private IToolActions m_ToolActionsCallbackInterface;
    private readonly InputAction m_Tool_LMB;
    private readonly InputAction m_Tool_RMB;
    private readonly InputAction m_Tool_MMB;
    private readonly InputAction m_Tool_Scroll;
    public struct ToolActions
    {
        private @PlayerInputActions m_Wrapper;
        public ToolActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LMB => m_Wrapper.m_Tool_LMB;
        public InputAction @RMB => m_Wrapper.m_Tool_RMB;
        public InputAction @MMB => m_Wrapper.m_Tool_MMB;
        public InputAction @Scroll => m_Wrapper.m_Tool_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_Tool; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ToolActions set) { return set.Get(); }
        public void SetCallbacks(IToolActions instance)
        {
            if (m_Wrapper.m_ToolActionsCallbackInterface != null)
            {
                @LMB.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnLMB;
                @LMB.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnLMB;
                @LMB.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnLMB;
                @RMB.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnRMB;
                @RMB.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnRMB;
                @RMB.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnRMB;
                @MMB.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnMMB;
                @MMB.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnMMB;
                @MMB.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnMMB;
                @Scroll.started -= m_Wrapper.m_ToolActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_ToolActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_ToolActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_ToolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LMB.started += instance.OnLMB;
                @LMB.performed += instance.OnLMB;
                @LMB.canceled += instance.OnLMB;
                @RMB.started += instance.OnRMB;
                @RMB.performed += instance.OnRMB;
                @RMB.canceled += instance.OnRMB;
                @MMB.started += instance.OnMMB;
                @MMB.performed += instance.OnMMB;
                @MMB.canceled += instance.OnMMB;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public ToolActions @Tool => new ToolActions(this);
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
        void OnMousePos(InputAction.CallbackContext context);
        void OnAD(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnHoldSpace(InputAction.CallbackContext context);
    }
    public interface IToolActions
    {
        void OnLMB(InputAction.CallbackContext context);
        void OnRMB(InputAction.CallbackContext context);
        void OnMMB(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}

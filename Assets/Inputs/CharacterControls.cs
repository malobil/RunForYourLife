// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/CharacterControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CharacterControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterControls"",
    ""maps"": [
        {
            ""name"": ""StandardInputs"",
            ""id"": ""2f591c7c-56ce-488e-86cb-d3f475480b65"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b70753f5-8860-493f-baf1-9db691798ce2"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b771de0-edf4-48e8-9646-a3bb80532d86"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""628f4930-4782-49cc-8fe2-c6ed26f9c07f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e9e5d17b-4738-4f6d-8a0b-48e634016186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fdad8648-79e0-453f-b648-774151a34ed1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dae0efce-5f3b-4082-9412-1d42d44f6703"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fadc16f1-ed00-4eee-90fd-17d2faf59a03"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a331ca2-9184-492f-a232-f3189a80743f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""66bed7e1-e558-4a74-b5ea-0a2c230a1e92"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9fe9ee52-7238-4106-bc7e-2dd83c304732"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""652854f1-36f2-4cd5-a47d-176611003e0f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1082a46-986a-44dd-80cc-13d74f65af70"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // StandardInputs
        m_StandardInputs = asset.FindActionMap("StandardInputs", throwIfNotFound: true);
        m_StandardInputs_Move = m_StandardInputs.FindAction("Move", throwIfNotFound: true);
        m_StandardInputs_MouseDelta = m_StandardInputs.FindAction("MouseDelta", throwIfNotFound: true);
        m_StandardInputs_Sprint = m_StandardInputs.FindAction("Sprint", throwIfNotFound: true);
        m_StandardInputs_Jump = m_StandardInputs.FindAction("Jump", throwIfNotFound: true);
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

    // StandardInputs
    private readonly InputActionMap m_StandardInputs;
    private IStandardInputsActions m_StandardInputsActionsCallbackInterface;
    private readonly InputAction m_StandardInputs_Move;
    private readonly InputAction m_StandardInputs_MouseDelta;
    private readonly InputAction m_StandardInputs_Sprint;
    private readonly InputAction m_StandardInputs_Jump;
    public struct StandardInputsActions
    {
        private @CharacterControls m_Wrapper;
        public StandardInputsActions(@CharacterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_StandardInputs_Move;
        public InputAction @MouseDelta => m_Wrapper.m_StandardInputs_MouseDelta;
        public InputAction @Sprint => m_Wrapper.m_StandardInputs_Sprint;
        public InputAction @Jump => m_Wrapper.m_StandardInputs_Jump;
        public InputActionMap Get() { return m_Wrapper.m_StandardInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardInputsActions set) { return set.Get(); }
        public void SetCallbacks(IStandardInputsActions instance)
        {
            if (m_Wrapper.m_StandardInputsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMove;
                @MouseDelta.started -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnMouseDelta;
                @Sprint.started -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_StandardInputsActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_StandardInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public StandardInputsActions @StandardInputs => new StandardInputsActions(this);
    public interface IStandardInputsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}

// GENERATED AUTOMATICALLY FROM 'Assets/GameFolders/Input/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Genel"",
            ""id"": ""ae1376c1-f7b1-4130-bef8-4f59466fbe60"",
            ""actions"": [
                {
                    ""name"": ""Held"",
                    ""type"": ""Button"",
                    ""id"": ""f741f45a-228f-401a-b20f-16f0ba74ae4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClickPosition"",
                    ""type"": ""Value"",
                    ""id"": ""3115f31f-1d4e-4a9f-8219-7e6369b5fa93"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""da83665b-ae87-465b-b04e-efeeb7185378"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ab3d316e-f6a8-4505-827c-9d19738aad7e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Held"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17af5201-df2b-4d63-a6a2-bd5982220ad3"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Held"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39064acc-a197-495a-8fe9-9ac5c40c392c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2bafe9e-b2ab-4d7d-9b86-88d32ca85d37"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClickPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95d95303-22a5-4923-8b89-0b66ff93fbac"",
                    ""path"": ""<Touchscreen>/touch0/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6f68148-a9ea-42e0-87ac-9e2e001330cf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Genel
        m_Genel = asset.FindActionMap("Genel", throwIfNotFound: true);
        m_Genel_Held = m_Genel.FindAction("Held", throwIfNotFound: true);
        m_Genel_ClickPosition = m_Genel.FindAction("ClickPosition", throwIfNotFound: true);
        m_Genel_Click = m_Genel.FindAction("Click", throwIfNotFound: true);
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

    // Genel
    private readonly InputActionMap m_Genel;
    private IGenelActions m_GenelActionsCallbackInterface;
    private readonly InputAction m_Genel_Held;
    private readonly InputAction m_Genel_ClickPosition;
    private readonly InputAction m_Genel_Click;
    public struct GenelActions
    {
        private @Input m_Wrapper;
        public GenelActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Held => m_Wrapper.m_Genel_Held;
        public InputAction @ClickPosition => m_Wrapper.m_Genel_ClickPosition;
        public InputAction @Click => m_Wrapper.m_Genel_Click;
        public InputActionMap Get() { return m_Wrapper.m_Genel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GenelActions set) { return set.Get(); }
        public void SetCallbacks(IGenelActions instance)
        {
            if (m_Wrapper.m_GenelActionsCallbackInterface != null)
            {
                @Held.started -= m_Wrapper.m_GenelActionsCallbackInterface.OnHeld;
                @Held.performed -= m_Wrapper.m_GenelActionsCallbackInterface.OnHeld;
                @Held.canceled -= m_Wrapper.m_GenelActionsCallbackInterface.OnHeld;
                @ClickPosition.started -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
                @ClickPosition.performed -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
                @ClickPosition.canceled -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
                @Click.started -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_GenelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Held.started += instance.OnHeld;
                @Held.performed += instance.OnHeld;
                @Held.canceled += instance.OnHeld;
                @ClickPosition.started += instance.OnClickPosition;
                @ClickPosition.performed += instance.OnClickPosition;
                @ClickPosition.canceled += instance.OnClickPosition;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public GenelActions @Genel => new GenelActions(this);
    public interface IGenelActions
    {
        void OnHeld(InputAction.CallbackContext context);
        void OnClickPosition(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}

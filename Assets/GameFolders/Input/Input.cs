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
                    ""name"": ""Click"",
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
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ca2940d-93b1-44ad-a505-ee33231eaf6c"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Genel
        m_Genel = asset.FindActionMap("Genel", throwIfNotFound: true);
        m_Genel_Click = m_Genel.FindAction("Click", throwIfNotFound: true);
        m_Genel_ClickPosition = m_Genel.FindAction("ClickPosition", throwIfNotFound: true);
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
    private readonly InputAction m_Genel_Click;
    private readonly InputAction m_Genel_ClickPosition;
    public struct GenelActions
    {
        private @Input m_Wrapper;
        public GenelActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Genel_Click;
        public InputAction @ClickPosition => m_Wrapper.m_Genel_ClickPosition;
        public InputActionMap Get() { return m_Wrapper.m_Genel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GenelActions set) { return set.Get(); }
        public void SetCallbacks(IGenelActions instance)
        {
            if (m_Wrapper.m_GenelActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_GenelActionsCallbackInterface.OnClick;
                @ClickPosition.started -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
                @ClickPosition.performed -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
                @ClickPosition.canceled -= m_Wrapper.m_GenelActionsCallbackInterface.OnClickPosition;
            }
            m_Wrapper.m_GenelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ClickPosition.started += instance.OnClickPosition;
                @ClickPosition.performed += instance.OnClickPosition;
                @ClickPosition.canceled += instance.OnClickPosition;
            }
        }
    }
    public GenelActions @Genel => new GenelActions(this);
    public interface IGenelActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnClickPosition(InputAction.CallbackContext context);
    }
}

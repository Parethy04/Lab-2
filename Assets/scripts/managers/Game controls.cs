//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/scripts/managers/game controls.inputactions
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

public partial class @Gamecontrols: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Gamecontrols()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""game controls"",
    ""maps"": [
        {
            ""name"": ""ingame"",
            ""id"": ""b1be2f1e-0aec-4f38-8bfd-4b54c4b25c3d"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""43732d4b-a419-4049-bc1a-07500323dc2f"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f4579019-7575-476c-adfe-29e85dc4b36c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""4a52ad0d-9bc1-4042-85e8-a567e7c085fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d94761b9-10b6-45aa-b750-4ec24592a2d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""reload"",
                    ""type"": ""Button"",
                    ""id"": ""fae8013c-0bd7-4d65-a4ba-76a648d29f84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f9213dc3-5f68-47ee-bd48-f43cf7581f5f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1909e9a1-bc0d-4789-a561-54d75b5dd0ef"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""66bd646f-e106-485c-8d44-e72c085658d1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""d21b85ee-13e2-4e76-9693-4046443a0daf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""89c50903-8be0-40c4-aa02-9e3a100537a9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""6243b2ba-dcc6-443b-9e74-44de894c4e02"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c7eb20e0-ec51-4eae-808a-9c356b1b3b42"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe9b2a02-d619-4ee0-ad1a-1776244f497e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d5dc3a7-6803-4cd5-94bc-410a3bd2782a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73e0f09d-1240-42af-b382-fa8cb90799af"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""6cbf6657-5326-40bc-af02-a74719f9f793"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""a8806cf0-4cac-4d0c-8857-25c12299fe50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce46ce4a-a049-40d0-a237-5f993400efc8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Permenant"",
            ""id"": ""2b6d71f5-9bdb-4c6f-adda-d34cd4448a4a"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": []
}");
        // ingame
        m_ingame = asset.FindActionMap("ingame", throwIfNotFound: true);
        m_ingame_movement = m_ingame.FindAction("movement", throwIfNotFound: true);
        m_ingame_jump = m_ingame.FindAction("jump", throwIfNotFound: true);
        m_ingame_Shoot = m_ingame.FindAction("Shoot", throwIfNotFound: true);
        m_ingame_look = m_ingame.FindAction("look", throwIfNotFound: true);
        m_ingame_reload = m_ingame.FindAction("reload", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
        // Permenant
        m_Permenant = asset.FindActionMap("Permenant", throwIfNotFound: true);
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

    // ingame
    private readonly InputActionMap m_ingame;
    private List<IIngameActions> m_IngameActionsCallbackInterfaces = new List<IIngameActions>();
    private readonly InputAction m_ingame_movement;
    private readonly InputAction m_ingame_jump;
    private readonly InputAction m_ingame_Shoot;
    private readonly InputAction m_ingame_look;
    private readonly InputAction m_ingame_reload;
    public struct IngameActions
    {
        private @Gamecontrols m_Wrapper;
        public IngameActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_ingame_movement;
        public InputAction @jump => m_Wrapper.m_ingame_jump;
        public InputAction @Shoot => m_Wrapper.m_ingame_Shoot;
        public InputAction @look => m_Wrapper.m_ingame_look;
        public InputAction @reload => m_Wrapper.m_ingame_reload;
        public InputActionMap Get() { return m_Wrapper.m_ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void AddCallbacks(IIngameActions instance)
        {
            if (instance == null || m_Wrapper.m_IngameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_IngameActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @look.started += instance.OnLook;
            @look.performed += instance.OnLook;
            @look.canceled += instance.OnLook;
            @reload.started += instance.OnReload;
            @reload.performed += instance.OnReload;
            @reload.canceled += instance.OnReload;
        }

        private void UnregisterCallbacks(IIngameActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @look.started -= instance.OnLook;
            @look.performed -= instance.OnLook;
            @look.canceled -= instance.OnLook;
            @reload.started -= instance.OnReload;
            @reload.performed -= instance.OnReload;
            @reload.canceled -= instance.OnReload;
        }

        public void RemoveCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IIngameActions instance)
        {
            foreach (var item in m_Wrapper.m_IngameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_IngameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public IngameActions @ingame => new IngameActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @Gamecontrols m_Wrapper;
        public UIActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);

    // Permenant
    private readonly InputActionMap m_Permenant;
    private List<IPermenantActions> m_PermenantActionsCallbackInterfaces = new List<IPermenantActions>();
    public struct PermenantActions
    {
        private @Gamecontrols m_Wrapper;
        public PermenantActions(@Gamecontrols wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_Permenant; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PermenantActions set) { return set.Get(); }
        public void AddCallbacks(IPermenantActions instance)
        {
            if (instance == null || m_Wrapper.m_PermenantActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PermenantActionsCallbackInterfaces.Add(instance);
        }

        private void UnregisterCallbacks(IPermenantActions instance)
        {
        }

        public void RemoveCallbacks(IPermenantActions instance)
        {
            if (m_Wrapper.m_PermenantActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPermenantActions instance)
        {
            foreach (var item in m_Wrapper.m_PermenantActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PermenantActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PermenantActions @Permenant => new PermenantActions(this);
    public interface IIngameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IPermenantActions
    {
    }
}
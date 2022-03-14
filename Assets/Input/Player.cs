//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/Player.inputactions
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

public partial class @Player : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""In-Game"",
            ""id"": ""cca9148a-5c06-4c59-97a1-f39a5e2cfa79"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""60fb669b-1254-4fd6-9374-3a87ed62818e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""2d7ba946-2cc4-4dba-97c3-ba0b8e8eb8f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Left Attack"",
                    ""type"": ""Button"",
                    ""id"": ""65c41943-b454-4cc1-a657-e76440b41b94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f643d924-6dab-4f55-ad38-dec10c6d103d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Combine"",
                    ""type"": ""Button"",
                    ""id"": ""45e88f5b-4c41-4d8d-bdee-2beb868e9815"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Separate"",
                    ""type"": ""Button"",
                    ""id"": ""3638cd36-b27b-4c99-afc0-b8d80fb71039"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JetBoost"",
                    ""type"": ""Button"",
                    ""id"": ""761c6b96-3b93-44b5-b56a-eebf2dce9c89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""427807bf-1d8c-458a-aacb-9b126f771abe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""010de6f7-e5ec-4090-9316-8b8b861ad664"",
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
                    ""id"": ""fda8b84c-20c2-496c-bd06-dbe5843d15ec"",
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
                    ""id"": ""5888195c-7f4b-4e60-a370-aac37f4c4713"",
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
                    ""id"": ""33373153-b503-4ad0-b198-9890dad79728"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b85f55e-3198-4be6-b397-e34ce67239b6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""30f5b5d6-9c44-4e01-beaf-946613c8b9ba"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2bd977f-f423-4abe-a4dd-c9e1734793cc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9e7aa65-d97c-4b21-9f36-0b46d68ed2ca"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8532aac-61ec-4a6c-b660-b2b1baf38afb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Combine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36d521ac-aaec-4b05-94e8-f276f925d090"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Separate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c50c44eb-c011-4df9-9cbc-56b035014caf"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JetBoost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d61a768c-14e7-4a68-9801-dcf69fccf08f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // In-Game
        m_InGame = asset.FindActionMap("In-Game", throwIfNotFound: true);
        m_InGame_Move = m_InGame.FindAction("Move", throwIfNotFound: true);
        m_InGame_Look = m_InGame.FindAction("Look", throwIfNotFound: true);
        m_InGame_LeftAttack = m_InGame.FindAction("Left Attack", throwIfNotFound: true);
        m_InGame_RightAttack = m_InGame.FindAction("Right Attack", throwIfNotFound: true);
        m_InGame_Combine = m_InGame.FindAction("Combine", throwIfNotFound: true);
        m_InGame_Separate = m_InGame.FindAction("Separate", throwIfNotFound: true);
        m_InGame_JetBoost = m_InGame.FindAction("JetBoost", throwIfNotFound: true);
        m_InGame_Pause = m_InGame.FindAction("Pause", throwIfNotFound: true);
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

    // In-Game
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Move;
    private readonly InputAction m_InGame_Look;
    private readonly InputAction m_InGame_LeftAttack;
    private readonly InputAction m_InGame_RightAttack;
    private readonly InputAction m_InGame_Combine;
    private readonly InputAction m_InGame_Separate;
    private readonly InputAction m_InGame_JetBoost;
    private readonly InputAction m_InGame_Pause;
    public struct InGameActions
    {
        private @Player m_Wrapper;
        public InGameActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InGame_Move;
        public InputAction @Look => m_Wrapper.m_InGame_Look;
        public InputAction @LeftAttack => m_Wrapper.m_InGame_LeftAttack;
        public InputAction @RightAttack => m_Wrapper.m_InGame_RightAttack;
        public InputAction @Combine => m_Wrapper.m_InGame_Combine;
        public InputAction @Separate => m_Wrapper.m_InGame_Separate;
        public InputAction @JetBoost => m_Wrapper.m_InGame_JetBoost;
        public InputAction @Pause => m_Wrapper.m_InGame_Pause;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLook;
                @LeftAttack.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftAttack;
                @LeftAttack.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftAttack;
                @LeftAttack.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftAttack;
                @RightAttack.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightAttack;
                @RightAttack.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightAttack;
                @RightAttack.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightAttack;
                @Combine.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCombine;
                @Combine.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCombine;
                @Combine.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCombine;
                @Separate.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnSeparate;
                @Separate.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnSeparate;
                @Separate.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnSeparate;
                @JetBoost.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnJetBoost;
                @JetBoost.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnJetBoost;
                @JetBoost.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnJetBoost;
                @Pause.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @LeftAttack.started += instance.OnLeftAttack;
                @LeftAttack.performed += instance.OnLeftAttack;
                @LeftAttack.canceled += instance.OnLeftAttack;
                @RightAttack.started += instance.OnRightAttack;
                @RightAttack.performed += instance.OnRightAttack;
                @RightAttack.canceled += instance.OnRightAttack;
                @Combine.started += instance.OnCombine;
                @Combine.performed += instance.OnCombine;
                @Combine.canceled += instance.OnCombine;
                @Separate.started += instance.OnSeparate;
                @Separate.performed += instance.OnSeparate;
                @Separate.canceled += instance.OnSeparate;
                @JetBoost.started += instance.OnJetBoost;
                @JetBoost.performed += instance.OnJetBoost;
                @JetBoost.canceled += instance.OnJetBoost;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    public interface IInGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnLeftAttack(InputAction.CallbackContext context);
        void OnRightAttack(InputAction.CallbackContext context);
        void OnCombine(InputAction.CallbackContext context);
        void OnSeparate(InputAction.CallbackContext context);
        void OnJetBoost(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
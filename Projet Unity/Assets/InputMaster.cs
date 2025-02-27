//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/InputMaster.inputactions
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

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Joueur"",
            ""id"": ""35aa0b3f-0a58-45bc-be4c-9f8a9eb3612d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f79334b2-2262-49ac-adb8-2e1babea89c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e3e9447f-3f74-44b9-b428-14abf7ce2c82"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Invisibility"",
                    ""type"": ""Button"",
                    ""id"": ""daac7d4f-d6c8-4e2e-a19f-9eff163c9e20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Stick gauche"",
                    ""id"": ""3888efe8-4d6d-42d5-b3e6-2786caec7fb3"",
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
                    ""id"": ""66fe91b6-d121-423f-bd76-cf7b65151d28"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c9e579e5-9128-4163-ac39-2d8e0f83f2f5"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5074a454-370f-458d-9bb2-2d58b042f491"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7d610b74-6850-4a08-a689-bfab96809f85"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""814716c0-c5d6-4562-8110-88279a7f7e3e"",
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
                    ""id"": ""1e4da01c-0a84-4391-bcfd-4f4ab1c8e684"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4139fe0f-4b86-45b3-807b-f4bd187913d3"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dd547a6b-e10f-4b5d-b7bd-5da19dd464af"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0832c9ac-94b9-468d-9007-073bca844e2a"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Flèches directionnelles"",
                    ""id"": ""490aee7a-a653-449b-a31a-4c8722b7a6fc"",
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
                    ""id"": ""369483a1-da9d-4f1a-8c25-2aaabc73b9c8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9a7246c9-455f-4e3d-af44-80acf8fa6a10"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a1819227-f21f-44ee-9a74-1f3faa33923d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8e16a11a-32c2-4f3f-bb23-dc3e19e414c9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""73cef722-8ccb-437a-a775-5694191e458f"",
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
                    ""id"": ""c584bdf8-08f9-46fc-9ae3-614243653160"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cc24c72a-489d-4adf-a9bb-f5feaae29eb1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""53382147-8ebb-4c6c-bff8-abcb16b6722e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""156ea220-3689-4bc2-b129-2f74cb92c736"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""05572bd5-82a8-491e-a8d7-4fa4f686d320"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27f4ac2a-b051-4fe3-a905-d35e6f7145ab"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19fcd02a-e3a1-48ca-8d41-656c25c7a071"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b4b580c-04bf-4f9f-81b0-b98b110d0a15"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f519a156-cfc6-44fa-a014-972ee776f4cb"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Invisibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3745c529-8d33-4a7a-b86a-4186ab6c9214"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Clavier souris"",
                    ""action"": ""Invisibility"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Clavier souris"",
            ""bindingGroup"": ""Clavier souris"",
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
        },
        {
            ""name"": ""Manette"",
            ""bindingGroup"": ""Manette"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Joueur
        m_Joueur = asset.FindActionMap("Joueur", throwIfNotFound: true);
        m_Joueur_Jump = m_Joueur.FindAction("Jump", throwIfNotFound: true);
        m_Joueur_Move = m_Joueur.FindAction("Move", throwIfNotFound: true);
        m_Joueur_Invisibility = m_Joueur.FindAction("Invisibility", throwIfNotFound: true);
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

    // Joueur
    private readonly InputActionMap m_Joueur;
    private IJoueurActions m_JoueurActionsCallbackInterface;
    private readonly InputAction m_Joueur_Jump;
    private readonly InputAction m_Joueur_Move;
    private readonly InputAction m_Joueur_Invisibility;
    public struct JoueurActions
    {
        private @InputMaster m_Wrapper;
        public JoueurActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Joueur_Jump;
        public InputAction @Move => m_Wrapper.m_Joueur_Move;
        public InputAction @Invisibility => m_Wrapper.m_Joueur_Invisibility;
        public InputActionMap Get() { return m_Wrapper.m_Joueur; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JoueurActions set) { return set.Get(); }
        public void SetCallbacks(IJoueurActions instance)
        {
            if (m_Wrapper.m_JoueurActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_JoueurActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_JoueurActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_JoueurActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_JoueurActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_JoueurActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_JoueurActionsCallbackInterface.OnMove;
                @Invisibility.started -= m_Wrapper.m_JoueurActionsCallbackInterface.OnInvisibility;
                @Invisibility.performed -= m_Wrapper.m_JoueurActionsCallbackInterface.OnInvisibility;
                @Invisibility.canceled -= m_Wrapper.m_JoueurActionsCallbackInterface.OnInvisibility;
            }
            m_Wrapper.m_JoueurActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Invisibility.started += instance.OnInvisibility;
                @Invisibility.performed += instance.OnInvisibility;
                @Invisibility.canceled += instance.OnInvisibility;
            }
        }
    }
    public JoueurActions @Joueur => new JoueurActions(this);
    private int m_ClaviersourisSchemeIndex = -1;
    public InputControlScheme ClaviersourisScheme
    {
        get
        {
            if (m_ClaviersourisSchemeIndex == -1) m_ClaviersourisSchemeIndex = asset.FindControlSchemeIndex("Clavier souris");
            return asset.controlSchemes[m_ClaviersourisSchemeIndex];
        }
    }
    private int m_ManetteSchemeIndex = -1;
    public InputControlScheme ManetteScheme
    {
        get
        {
            if (m_ManetteSchemeIndex == -1) m_ManetteSchemeIndex = asset.FindControlSchemeIndex("Manette");
            return asset.controlSchemes[m_ManetteSchemeIndex];
        }
    }
    public interface IJoueurActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnInvisibility(InputAction.CallbackContext context);
    }
}

// GENERATED AUTOMATICALLY FROM 'Assets/Input System Settings/MyControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyControls"",
    ""maps"": [
        {
            ""name"": ""MainCharacter"",
            ""id"": ""1ccbc606-84af-444a-8e66-5b74682faecd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b80fc319-8b59-4a5b-aa53-6be785927909"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0b0cc5c2-0923-4fc9-a9b9-e5160f70fcbb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6496ca5d-d480-4b93-bc9e-04ce9d1dfb04"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fa2b33b3-ab32-4078-9cc5-d36c052aaa9f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8bcea05e-b34a-4ce6-b785-fa6d3efbd095"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3052ae1d-d703-4c7d-97c3-a28d5e816695"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MainCharacter
        m_MainCharacter = asset.FindActionMap("MainCharacter", throwIfNotFound: true);
        m_MainCharacter_Movement = m_MainCharacter.FindAction("Movement", throwIfNotFound: true);
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

    // MainCharacter
    private readonly InputActionMap m_MainCharacter;
    private IMainCharacterActions m_MainCharacterActionsCallbackInterface;
    private readonly InputAction m_MainCharacter_Movement;
    public struct MainCharacterActions
    {
        private @MyControls m_Wrapper;
        public MainCharacterActions(@MyControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_MainCharacter_Movement;
        public InputActionMap Get() { return m_Wrapper.m_MainCharacter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainCharacterActions set) { return set.Get(); }
        public void SetCallbacks(IMainCharacterActions instance)
        {
            if (m_Wrapper.m_MainCharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MainCharacterActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_MainCharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public MainCharacterActions @MainCharacter => new MainCharacterActions(this);
    public interface IMainCharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class switchactionMap : MonoBehaviour
{
    [SerializeField] private GameObject eventSystem;
    [SerializeField] private InputActionAsset inGameActionMap;
    [SerializeField] private PlayerInput _playerInput;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem.GetComponent<InputSystemUIInputModule>().actionsAsset = inGameActionMap;
        OnEnable();
    }

    private void OnEnable()
    {
        
        _playerInput.SwitchCurrentActionMap("inGameControle");
    }
}

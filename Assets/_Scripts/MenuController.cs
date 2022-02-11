using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [HideInInspector] public bool IsUsing;
    [SerializeField] private Transform _soundSphereControls;
    void Start()
    {
        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Toggle the sound menu
            IsUsing = !IsUsing;
            _soundSphereControls.gameObject.SetActive(IsUsing);
            Cursor.lockState = IsUsing ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = IsUsing;
        }
    }
}
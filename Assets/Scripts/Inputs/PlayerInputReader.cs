using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour, PlayerControls.IPlayerActions
{
    PlayerControls controls;

    public event Action TargetPressed;
    public Vector2 MovementValue {  get; private set; }

    void Start()
    {
        controls = new PlayerControls();
        controls.Player.SetCallbacks(this);

        controls.Player.Enable();
    }

    void OnDestroy()
    {
        controls.Player.Disable();
    }

    public void OnTarget(InputAction.CallbackContext context)
    {
        if (context.performed == false)
        {
            return;
        }

        Debug.Log("Target ��ư�� ���Ƚ��ϴ�.");

        TargetPressed?.Invoke();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        MovementValue = context.ReadValue<Vector2>();
        //Debug.Log(MovementValue);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }
}

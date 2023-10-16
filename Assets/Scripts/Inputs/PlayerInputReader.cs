using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputReader : MonoBehaviour, PlayerControls.IPlayerActions
{
    public event Action TargetPressed;

    PlayerControls controls;

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

        Debug.Log("Target 버튼이 눌렸습니다.");

        TargetPressed?.Invoke();
    }

}

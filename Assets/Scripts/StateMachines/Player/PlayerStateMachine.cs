// 플레이어의 (유한) 상태 기계(FSM)
using UnityEngine;

public class PlayerStateMachine : BaseStateMachine
{
    public float FreeLookMoveSpeed = 6f;
    public float AnimationDampingTime = 0.1f;
    public float RotationDampingTime = 1f;

    public CharacterController Controller;
    public PlayerInputReader InputReader;
    public Animator Animator;

    void Start()
    {
        SwitchState(new PlayerFreeLookState(this));
    }
}

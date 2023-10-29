// 플레이어가 자유롭게 돌아다니면서 카메라 시점을 바꿀 수 있는 상태
using System;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
    const string FREE_LOOK_SPEED = "FreeLookSpeed";
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    // Target 버튼, 즉 키보드 탭 또는 미들클릭을 했을 때
    void OnTargetPressed()
    {
        stateMachine.SwitchState(new PlayerTargetingState(stateMachine));
    }

    public override void Enter()
    {
        //Debug.Log("PlayerFreeLookState에 진입합니다.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        //Debug.Log("PlayerFreeLookState를 종료합니다.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        //Debug.Log("PlayerFreeLookState를 갱신합니다.");

        // 위치 처리
        Vector3 movement = CalculateMovement();
        stateMachine.Controller.Move(movement * stateMachine.FreeLookMoveSpeed * deltatime);

        // 회전 처리
        if (stateMachine.InputReader.MovementValue != Vector2.zero)
            stateMachine.transform.rotation = CalculateRotation(movement, deltatime);

        // 애니메이션 처리
        if (stateMachine.InputReader.MovementValue == Vector2.zero)
            stateMachine.Animator.SetFloat(FREE_LOOK_SPEED, 0f, stateMachine.AnimationDampingTime, deltatime);
        else
            stateMachine.Animator.SetFloat(FREE_LOOK_SPEED, 1f, stateMachine.AnimationDampingTime, deltatime);

    }

    private Vector3 CalculateMovement()
    {
        Vector3 movement = new Vector3();
        movement.x = stateMachine.InputReader.MovementValue.x;
        movement.y = 0f;
        movement.z = stateMachine.InputReader.MovementValue.y;
        return movement;
    }

    private Quaternion CalculateRotation(Vector3 movement, float deltatime)
    {
        return Quaternion.Lerp(stateMachine.transform.rotation, Quaternion.LookRotation(movement),
            stateMachine.RotationDampingTime * deltatime);
    }
}

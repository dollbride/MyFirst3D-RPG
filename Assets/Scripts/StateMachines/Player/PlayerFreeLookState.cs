// �÷��̾ �����Ӱ� ���ƴٴϸ鼭 ī�޶� ������ �ٲ� �� �ִ� ����
using System;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
    const string FREE_LOOK_SPEED = "FreeLookSpeed";
    public PlayerFreeLookState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    // Target ��ư, �� Ű���� �� �Ǵ� �̵�Ŭ���� ���� ��
    void OnTargetPressed()
    {
        stateMachine.SwitchState(new PlayerTargetingState(stateMachine));
    }

    public override void Enter()
    {
        //Debug.Log("PlayerFreeLookState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        //Debug.Log("PlayerFreeLookState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        //Debug.Log("PlayerFreeLookState�� �����մϴ�.");

        // ��ġ ó��
        Vector3 movement = CalculateMovement();
        stateMachine.Controller.Move(movement * stateMachine.FreeLookMoveSpeed * deltatime);

        // ȸ�� ó��
        if (stateMachine.InputReader.MovementValue != Vector2.zero)
            stateMachine.transform.rotation = CalculateRotation(movement, deltatime);

        // �ִϸ��̼� ó��
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

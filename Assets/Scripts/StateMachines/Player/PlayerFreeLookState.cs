// �÷��̾ �����Ӱ� ���ƴٴϸ鼭 ī�޶� ������ �ٲ� �� �ִ� ����
using System;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
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
        Debug.Log("PlayerFreeLookState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        Debug.Log("PlayerFreeLookState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        Debug.Log("PlayerFreeLookState�� �����մϴ�.");
    }
}

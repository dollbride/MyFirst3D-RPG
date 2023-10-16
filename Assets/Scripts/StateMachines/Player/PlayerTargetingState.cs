// �÷��̾ ���� �ٶ󺸰� �ִ� ���¿��� ī�޶� ������ �ٲ� �� �ִ� ����
using UnityEngine;

public class PlayerTargetingState : PlayerBaseState
{
    public PlayerTargetingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    // Target ��ư, �� Ű���� �� �Ǵ� �̵�Ŭ���� ���� ��
    void OnTargetPressed()
    {
        stateMachine.SwitchState(new PlayerFreeLookState(stateMachine));
    }

    public override void Enter()
    {
        Debug.Log("PlayerTargetingState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        Debug.Log("PlayerTargetingState�� �����մϴ�.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        Debug.Log("PlayerTargetingState�� �����մϴ�.");
    }
}

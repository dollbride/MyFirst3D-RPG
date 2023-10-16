// 플레이어가 자유롭게 돌아다니면서 카메라 시점을 바꿀 수 있는 상태
using System;
using UnityEngine;

public class PlayerFreeLookState : PlayerBaseState
{
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
        Debug.Log("PlayerFreeLookState에 진입합니다.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        Debug.Log("PlayerFreeLookState를 종료합니다.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        Debug.Log("PlayerFreeLookState를 갱신합니다.");
    }
}

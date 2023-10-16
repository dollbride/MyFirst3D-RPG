// 플레이어가 적을 바라보고 있는 상태에서 카메라 시점을 바꿀 수 있는 상태
using UnityEngine;

public class PlayerTargetingState : PlayerBaseState
{
    public PlayerTargetingState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    // Target 버튼, 즉 키보드 탭 또는 미들클릭을 했을 때
    void OnTargetPressed()
    {
        stateMachine.SwitchState(new PlayerFreeLookState(stateMachine));
    }

    public override void Enter()
    {
        Debug.Log("PlayerTargetingState에 진입합니다.");

        stateMachine.InputReader.TargetPressed += OnTargetPressed;
    }

    public override void Exit()
    {
        Debug.Log("PlayerTargetingState를 종료합니다.");

        stateMachine.InputReader.TargetPressed -= OnTargetPressed;
    }

    public override void Tick(float deltatime)
    {
        Debug.Log("PlayerTargetingState를 갱신합니다.");
    }
}

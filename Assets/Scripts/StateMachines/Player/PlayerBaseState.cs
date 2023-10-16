// 플레이어의 기반 상태
public class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public override void Enter()                 //진입 함수 ~ Start()
    {

    }

    public override void Exit()                 //종료 함수 ~ OnDestroy()
    {

    }

    public override void Tick(float deltatime)  //갱신 함수 ~ Update()
    {

    }
}

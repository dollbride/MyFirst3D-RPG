// �÷��̾��� ��� ����
public class PlayerBaseState : State
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    public override void Enter()                 //���� �Լ� ~ Start()
    {

    }

    public override void Exit()                 //���� �Լ� ~ OnDestroy()
    {

    }

    public override void Tick(float deltatime)  //���� �Լ� ~ Update()
    {

    }
}

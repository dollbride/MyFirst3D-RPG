// �÷��̾��� (����) ���� ���(FSM)
public class PlayerStateMachine : BaseStateMachine
{
    public PlayerInputReader InputReader;

    void Start()
    {
        SwitchState(new PlayerFreeLookState(this));
    }
}

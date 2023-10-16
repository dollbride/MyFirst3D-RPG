// 플레이어의 (유한) 상태 기계(FSM)
public class PlayerStateMachine : BaseStateMachine
{
    public PlayerInputReader InputReader;

    void Start()
    {
        SwitchState(new PlayerFreeLookState(this));
    }
}

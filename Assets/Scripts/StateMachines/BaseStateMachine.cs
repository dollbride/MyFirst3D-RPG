using UnityEngine;

// 상태 머신 : 플레이어나 적의 상태 정보 또는 두뇌(체력, 공격력)
public class BaseStateMachine : MonoBehaviour
{
    // 현재 상태
    State currentState = null;

    // 상태를 변경하는 함수. 전이(transition)로서의 함수
    public void SwitchState(State newState)
    {
        currentState?.Exit();   // null 체크 후 널이 "아닐 경우" Exit() 실행
        currentState = newState;
        currentState.Enter();
    }

    private void Update()
    {
        currentState.Tick(Time.deltaTime);
    }

}

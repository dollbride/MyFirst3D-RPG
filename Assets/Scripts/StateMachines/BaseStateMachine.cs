using UnityEngine;

// ���� �ӽ� : �÷��̾ ���� ���� ���� �Ǵ� �γ�(ü��, ���ݷ�)
public class BaseStateMachine : MonoBehaviour
{
    // ���� ����
    State currentState = null;

    // ���¸� �����ϴ� �Լ�. ����(transition)�μ��� �Լ�
    public void SwitchState(State newState)
    {
        currentState?.Exit();   // null üũ �� ���� "�ƴ� ���" Exit() ����
        currentState = newState;
        currentState.Enter();
    }

    private void Update()
    {
        currentState.Tick(Time.deltaTime);
    }

}

using UnityEngine;

// (����) ���� ��谡 ���� �� �ִ� �� ����
// e.g. Idle, Attacking, Targeting. Dead
// ������ �з�, �������μ��� Ŭ����(abstract)�̱� ������ MonoBehavior�� ��ӹ��� �ʿ� ����
public abstract class State
{
    // A��� ���¿��� B���·� ����
    public abstract void Enter();                   // ���� �Լ� ~ Start()
    public abstract void Tick(float deltatime);     // ���� �Լ� ~ Update()
    public abstract void Exit();                    // ���� �Լ� OnDestroy()
}

using UnityEngine;

// (유한) 상태 기계가 가질 수 있는 각 상태
// e.g. Idle, Attacking, Targeting. Dead
// 일종의 분류, 개념으로서의 클래스(abstract)이기 때문에 MonoBehavior를 상속받을 필요 없음
public abstract class State
{
    // A라는 상태에서 B상태로 전이
    public abstract void Enter();                   // 진입 함수 ~ Start()
    public abstract void Tick(float deltatime);     // 갱신 함수 ~ Update()
    public abstract void Exit();                    // 종료 함수 OnDestroy()
}

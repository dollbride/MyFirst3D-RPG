using System;
using UnityEngine;

public class ConstructorTest : MonoBehaviour
{
    // 캐릭터 클래스를 상속받는 다양한 캐릭터들
    [Serializable]
    public class Archer : Character
    {
        public int attack;
        public Archer(int attack, int health) : base(health)
        {
            this.attack = attack;
        }

        // 기반 클래스에 정의된 추상 메소드를 오버라이드(재정의)
        public override void Attack()
        {
            Debug.Log("활로 공격합니다");
        }
    }

    [Serializable]
    public class Knight : Character
    {
        public int defence;
        public Knight(string name, int health, int defence) : base(name, health)
        {
            this.defence = defence;
        }

        public override void Attack()
        {
            Debug.Log("칼로 공격합니다");
        }
    }

    // 캐릭터 클래스 오버로딩(다중정의)
    public abstract class Character
    {
        public string name;
        public int health;

        public Character()
        {
            //Debug.Log("캐릭터1가 생성되었습니다. 인자가 없는 생성자");
            health = 1;
        }

        public Character(int health)
        {
            Debug.Log($"궁수가 생성되었습니다. 체력은 {health}");
            this.health = health;
        }

        public Character(string name, int health)
        {
            Debug.Log($"캐릭터 \"{name}\"가 생성되었습니다. 체력은 {health}");
            this.name = name;
            this.health = health;
        }

        public abstract void Attack();

    }

    public Archer archer;
    public Knight knight;

    // Start is called before the first frame update
    void Start()
    {
        archer = new Archer(50, 300);
        knight = new Knight("기사", 500, 80);

        archer.Attack();
        knight.Attack();
    }

}

using System;
using UnityEngine;

public class ConstructorTest : MonoBehaviour
{
    // ĳ���� Ŭ������ ��ӹ޴� �پ��� ĳ���͵�
    [Serializable]
    public class Archer : Character
    {
        public int attack;
        public Archer(int attack, int health) : base(health)
        {
            this.attack = attack;
        }

        // ��� Ŭ������ ���ǵ� �߻� �޼ҵ带 �������̵�(������)
        public override void Attack()
        {
            Debug.Log("Ȱ�� �����մϴ�");
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
            Debug.Log("Į�� �����մϴ�");
        }
    }

    // ĳ���� Ŭ���� �����ε�(��������)
    public abstract class Character
    {
        public string name;
        public int health;

        public Character()
        {
            //Debug.Log("ĳ����1�� �����Ǿ����ϴ�. ���ڰ� ���� ������");
            health = 1;
        }

        public Character(int health)
        {
            Debug.Log($"�ü��� �����Ǿ����ϴ�. ü���� {health}");
            this.health = health;
        }

        public Character(string name, int health)
        {
            Debug.Log($"ĳ���� \"{name}\"�� �����Ǿ����ϴ�. ü���� {health}");
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
        knight = new Knight("���", 500, 80);

        archer.Attack();
        knight.Attack();
    }

}

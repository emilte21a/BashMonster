namespace BashMonster;

public class Enemy
{
    public int Health;

    public virtual void Attack(){}
}

public class Goblin : Enemy{

    public Goblin(){
        Health = 5000;
    }

    public override void Attack()
    {
        System.Console.WriteLine("subllw");
    }
}
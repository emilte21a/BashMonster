namespace BashMonster;

public class Weapon
{
    public int damage;
    public int CriticalHitDamage;
    public string Name;
}

public class RPG : Weapon
{
    public RPG()
    {
        damage = 300;
        CriticalHitDamage = 400;
        Name = "RPG";
    }
}

public class Sword : Weapon
{
    public Sword()
    {
        damage = 100;
        CriticalHitDamage = 200;
        Name = "Sword";
    }
}

public class Stone : Weapon
{
    public Stone()
    {
        damage = 5;
        CriticalHitDamage = 1000;
        Name = "Stone";
    }
}

public class Pistol : Weapon
{
    public Pistol()
    {
        damage = 150;
        CriticalHitDamage = 450;
        Name = "Pistol";
    }
}
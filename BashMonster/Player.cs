namespace BashMonster;
using System.Collections.Generic;
using System.Data;

public class Player
{
    public string Name;
    public int Health;
    public string Weapon;
    public int ArmorAmount;

    Weapon weapon = new();
    Goblin enemy = new();

    public int AttackEnemy(Weapon weapon)
    {
        enemy.Health -= weapon.damage;
        System.Console.WriteLine($"Du använde {weapon.Name}! Den gjorde {weapon.damage} skada!");
        System.Console.WriteLine($"fienden har {enemy.Health} liv kvar!");
        return enemy.Health;
    }

    public string ChooseWeapon(string weapon1)
    {
        Console.WriteLine("Vilket vapen vill du ha?");
        Console.WriteLine("Skriv vapnets namn!");
        for (int i = 0; i < weapon.Weapons.Length; i++)
        {
            Console.WriteLine(i + 1 + ": " + weapon.Weapons[i]);
        }

            weapon1 = Console.ReadLine().ToLower(); 
        while (!weapon.Weapons.Contains(weapon1.ToLower()))
        {
            Console.WriteLine("Skriv ett vapen som finns");
            weapon1 = Console.ReadLine().ToLower(); 
        }
        return weapon1.ToLower();
    }
}

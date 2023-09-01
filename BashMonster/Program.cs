//Ett spel med en huvudkaraktär som har ett flertal vapen (svärd, pistol, rpg och en sten)
//Huvudkaraktären ska själv kunna välja vilket vapen de ska använda för att attackera en fiende
//Fienden ska ha mycket liv (5000 ungefär). 
//Alla vapen ska ha varierande skada och kunna göra critical hits

using BashMonster;

Goblin enemy = new();
Player player = new();
Weapon weapon = new();
RPG rPG = new();
Sword sword = new();
Stone stone = new();
Pistol pistol = new();

Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>();

weapons.Add("rpg", rPG);
weapons.Add("sword", sword);
weapons.Add("stone", stone);
weapons.Add("pistol", pistol);

string PlayerWeapon;

while (1 > 0)
{
    PlayerWeapon = player.ChooseWeapon("");

    /*
    foreach (var item in weapons)
    {
        if (PlayerWeapon == item.Key)
        {
            weapon = weapons(item.Value);
        }
    }
    */

    foreach (KeyValuePair<string, Weapon> item in weapons)
    {
        if (PlayerWeapon == item.Key)
        {
            weapon = weapons[item.Value];
        }
    }

    player.AttackEnemy(weapon);
    System.Console.WriteLine("");
}



Console.ReadLine();
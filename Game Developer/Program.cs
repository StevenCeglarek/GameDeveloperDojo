// See https://aka.ms/new-console-template for more information
using Game_Developer;

Console.WriteLine("Hello, World!");

Enemy enemy = new Enemy("Evil Batman");

Attack attack1 = new Attack("Evil Bat Bat", 5);
Attack attack2 = new Attack("Evil Bat Gun", 8);
Attack attack3 = new Attack("Evil Bat Flashbang", 1);

enemy.addToAttackList(attack1);
enemy.addToAttackList(attack2);
enemy.addToAttackList(attack3);

Console.WriteLine(enemy.RandomAttack());
Console.WriteLine(enemy.RandomAttack());
Console.WriteLine(enemy.RandomAttack());
Console.WriteLine(enemy.RandomAttack());

enemy.ShowHealth();
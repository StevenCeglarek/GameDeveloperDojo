// See https://aka.ms/new-console-template for more information
using Game_Developer;

Console.WriteLine("Hello, World!");

Enemy evilBat = new Enemy("Evil Batman");
Enemy goodBat = new Enemy("Good Batman");
MeleeFighter meleeBat = new MeleeFighter("Melee Batman");
RangedFighter rangedBat = new RangedFighter("Ranged Batman");
MagicCaster magicBat = new MagicCaster("Magic Batman");

Attack attack1 = new Attack("Evil Bat Bat", 5);
Attack attack2 = new Attack("Evil Bat Gun", 8);
Attack attack3 = new Attack("Evil Bat Flashbang", 1);

evilBat.addToAttackList(attack1);
evilBat.addToAttackList(attack2);
evilBat.addToAttackList(attack3);

Attack attack4 = new Attack("Good Bat Bat", 5);
Attack attack5 = new Attack("Good Bat Gun", 8);
Attack attack6 = new Attack("Good Bat Flashbang", 1);

goodBat.addToAttackList(attack4);
goodBat.addToAttackList(attack5);
goodBat.addToAttackList(attack6);

evilBat.ShowHealth();
goodBat.ShowHealth();

//goodBat.PerformAttack(evilBat, goodBat.RandomAttack());
//meleeBat.Rage(evilBat);
//meleeBat.Rage(goodBat);
//rangedBat.PerformAttack(meleeBat, rangedBat.RandomAttack());
//rangedBat.Dash();
//rangedBat.PerformAttack(meleeBat, rangedBat.RandomAttack());

//magicBat.Heal(goodBat);


// Assignment list of items
meleeBat.PerformAttack(rangedBat, meleeBat.AttackList[1]);
meleeBat.Rage(magicBat);
rangedBat.PerformAttack(meleeBat, rangedBat.AttackList[0]);
rangedBat.Dash();
rangedBat.PerformAttack(meleeBat, rangedBat.AttackList[0]);
magicBat.PerformAttack(meleeBat, magicBat.AttackList[0]);
magicBat.Heal(rangedBat);
magicBat.Heal(magicBat);

using System;
namespace Game_Developer
{
	public class MeleeFighter : Enemy
	{
		public MeleeFighter(string name) : base(name)
		{
			Health = 120;
			DefaultAttacksCreated();

        }

		public void DefaultAttacksCreated()
		{
			Attack attack1 = new Attack("Punch", 20);
			Attack attack2 = new Attack("Kick", 15);
			Attack attack3 = new Attack("Tackle", 25);

			addToAttackList(attack1);
			addToAttackList(attack2);
			addToAttackList(attack3);
        }

		public void Rage(Enemy Target)
		{
			Attack randomAttack = this.RandomAttack();
			Target.Health = Target.Health - (randomAttack.DamageAmount + 10);
            Console.WriteLine($"{this.Name} rage attacks {Target.Name}, dealing {randomAttack.DamageAmount + 10} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
	}
}


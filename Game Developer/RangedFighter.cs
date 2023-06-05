using System;
namespace Game_Developer
{
	public class RangedFighter : Enemy
	{
		public int Distance;

		public RangedFighter(string name) : base(name)
		{
			this.Distance = 5;
            DefaultAttacksCreated();

        }

        public void DefaultAttacksCreated()
        {
            Attack attack1 = new Attack("Shoot An Arrow", 20);
            Attack attack2 = new Attack("Throw a Knife", 15);

            addToAttackList(attack1);
            addToAttackList(attack2);
        }

        public override void PerformAttack(Enemy Target, Attack ChosenAttack)
        {
            if(Distance < 10)
            {
                Console.WriteLine("You are not in range to attack");
            }
            else
            {
                Target.Health = Target.Health - ChosenAttack.DamageAmount;
                Console.WriteLine($"{this.Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
            }
        }

        public void Dash()
        {
            this.Distance = 20;
            Console.WriteLine($"{this.Name}'s Distance is now set to 20");
        }
    }
}


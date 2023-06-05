using System;
namespace Game_Developer
{
	public class MagicCaster : Enemy
	{
		public MagicCaster(string name) : base(name)
		{
			this.Health = 80;
            DefaultAttacksCreated();

        }

        public void DefaultAttacksCreated()
        {
            Attack attack1 = new Attack("Fireball", 25);
            Attack attack2 = new Attack("Lightning Bolt", 20);
            Attack attack3 = new Attack("Staff Strike", 10);

            addToAttackList(attack1);
            addToAttackList(attack2);
            addToAttackList(attack3);
        }

        public void Heal(Enemy Target)
        {
            Target.Health = Target.Health + 40;
            Console.WriteLine($"{this.Name} just healed {Target.Name} for an extra 40 points. Their new healt is {Target.Health}");
        }
    }
}


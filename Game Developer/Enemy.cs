using System;
namespace Game_Developer
{
	public class Enemy
	{
		public string Name;
		private int _health;

		public int Health
		{
			get
			{
				return _health;
			}
			set
			{
				_health = value;
			}
		}
		public List<Attack> AttackList;

		public Enemy(string name)
		{
			this.Name = name;
			this.Health = 100;
			this.AttackList = new List<Attack>();

        }

		public Attack RandomAttack()
		{
			Random rand = new Random();
			long randNum = rand.NextInt64(0, this.AttackList.Count);
			int num = (int)randNum;
			Attack randAttack = this.AttackList[num];

			return randAttack;
		}

		public void ShowHealth()
		{
			Console.WriteLine(this.Name + "'s health is currently: " + this.Health);
		}

		public List<Attack> addToAttackList(Attack attackToBeAdded)
		{
			this.AttackList.Add(attackToBeAdded);
			return this.AttackList;
		}

        // Inside of the Enemy class
        public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
        {
			Target.Health = Target.Health - ChosenAttack.DamageAmount;
            Console.WriteLine($"{this.Name} attacks {Target.Name} using {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }




    }
}


using System;
namespace Game_Developer
{
	public class Attack
	{
        public string Name;
        public int DamageAmount;

        public Attack(string name, int damageAmount)
        {
            this.Name = name;
            this.DamageAmount = damageAmount;
        }

        override
        public string ToString()
        {
            return "Attack used is " + this.Name + ", attack damage is " + this.DamageAmount;
        }
    }
}


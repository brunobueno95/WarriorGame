using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal abstract class Avatar
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }


        public int Speed { get; set; }

        public Avatar(string name, int health, int power, int speed)
        {
            Name = name;
            Health = health;
            Power = power;
            Speed = speed;
            
        }

        public void Attack(Avatar FightingAgainst)
        {
            var attack = 10;
            FightingAgainst.Health -= attack;
        }

        public string Description()
        {
            var description = $"{Name} has health: {Health}, power: {Power}, agility: {Speed}";
            return description;
        }
        
        public int InBattleHealth()
        {
            return Health;
        }
    }
}

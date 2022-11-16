using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Warrior : Avatar
    {

        public int Level { get; set; }

        public Weapon WeaponUsing { get; set; }
        public Warrior(string name, int health, int power, int speed) : base(name, health, power, speed)
        {
            Level = 1;
        }
    }
}

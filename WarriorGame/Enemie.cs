using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Enemie : Avatar
    {
        public Enemie(string name, int health, int power, int speed) : base(name, health, power, speed)
        {
        }
    }
}

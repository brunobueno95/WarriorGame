using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Potion : IItem
    {
        public string Name { get ; set; }
        public int price { get; set; }
        public string Description { get; private set; }
        public int PowerIncrease { get;set; }
        public int HealthIncrease { get; set; }
        public int SpeedIncrease { get; set ; }


        public Potion(string name, int Price, int powerIncrease, int healthIncrease, int speedIncrease)
        {
            Name = name;
            price = Price;
            PowerIncrease = powerIncrease;
            HealthIncrease = healthIncrease;
            SpeedIncrease = speedIncrease;

        }

        public void description()
        {
            Description = $"The Potion {Name} costs {price}.It increases your warrior power in {PowerIncrease}, the speed in {SpeedIncrease} and the health in {HealthIncrease} ";
            
        }

        public void Use(User TheUser)
        {
            TheUser.YourAvatar.Power += PowerIncrease;
            TheUser.YourAvatar.Health += HealthIncrease;
            TheUser.YourAvatar.Speed += SpeedIncrease;
            TheUser.AllItems.Remove(this);
           
        }
    }
}

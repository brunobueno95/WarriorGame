using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Weapon : IItem
    {
        public string Name { get ; set; }
        public int price { get; set; }
        public string Description { get; private set; }

        public bool isUsing { get; private set; }
        public int PowerIncrease { get; set; }
        public int HealthIncrease { get ; set; }
        public int SpeedIncrease { get ; set; }
       

        public Weapon(string name, int Price, int powerIncrease, int healthIncrease, int speedIncrease)
        {
            Name = name;
            price = Price;
            PowerIncrease = powerIncrease;
            HealthIncrease = healthIncrease;
            SpeedIncrease = speedIncrease;

        }

        public void stopUsing(Warrior User)
        {
            User.WeaponUsing.PowerIncrease -= User.Power;
            User.WeaponUsing.HealthIncrease -= User.Health;
            User.WeaponUsing.SpeedIncrease -= User.Speed;
            User.WeaponUsing = null;

        }
        public void Use(User TheUser)
        {
            stopUsing(TheUser.YourAvatar);
            TheUser.YourAvatar.WeaponUsing = this;
            TheUser.YourAvatar.Power += PowerIncrease;
            TheUser.YourAvatar.Health += HealthIncrease;
            TheUser.YourAvatar.Speed += SpeedIncrease;


        }

        public void description()
        {
            Description = $"The Weapon {Name} costs {price}.It increases your warrior power in {PowerIncrease}, the speed in {SpeedIncrease} and the health in {HealthIncrease},While using the weapon. ";
        }
    }
}

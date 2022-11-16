using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class User : IUser
    {
        public List<IItem> AllItems { get; set; } = new List<IItem>();
        public string Name { get; set; }
        public int GoldCoins { get; set; }
        public Warrior YourAvatar { get; set; }

        public User(string name)
        {
            Name = name;
            GoldCoins = 150;
        }

        public string Description()
        {
            return $"{Name} you have {GoldCoins} gold coins.\n Info about your Avatar: {YourAvatar.Description()} ";
        }

    }
}

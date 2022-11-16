using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class ItemShop : IItemShop
    {
        public List<IItem> AllAvailableItems = new List<IItem>();

        public IItem SelectedItem { get; set; }

        public string Buy(IUser TheUser)
        {
            if (TheUser.GoldCoins >= SelectedItem.price)
            {
                TheUser.AllItems.Add(SelectedItem);
                TheUser.GoldCoins -= SelectedItem.price;
                var boughtit = $"You bought {SelectedItem.Name}";
                return boughtit;
            }
            else
            {
                var NotEnoughGoldCoins = $"{SelectedItem.Name} costs more than you can afford";
                return NotEnoughGoldCoins;
            }

        }

    }
}

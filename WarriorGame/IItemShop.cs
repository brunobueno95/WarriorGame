namespace WarriorGame
{
    internal interface IItemShop
    {
        public List<IItem> AllAvailableItems { get; }

        public IItem SelectedItem { get; set; }

        public string Buy(IUser TheUser);
    }
}
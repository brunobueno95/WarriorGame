namespace WarriorGame
{
    internal interface IItemShop
    {
        IItem SelectedItem { get; set; }

        string Buy(IUser TheUser);
    }
}
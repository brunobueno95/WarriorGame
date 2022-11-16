namespace WarriorGame
{
    internal interface IUser
    {
        List<IItem> AllItems { get; set; }
        int GoldCoins { get; set; }
        string Name { get; set; }
        Warrior YourAvatar { get; set; }

        string Description();
    }
}
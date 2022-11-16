namespace WarriorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App(new ItemShop(), new User(""), new BattleField());
            app.RunApp();
        }
    }
}
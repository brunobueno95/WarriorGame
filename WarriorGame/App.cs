using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class App
    {
        public List<Avatar> AllAvatarsInTheGame = new List<Avatar>();

        private IItemShop _shop;
        private IUser _player;
        private IBattleField _battle;
        public App(IItemShop shop, IUser player, IBattleField battle)
        {
            _shop = shop;
            _player = player;
            _battle = battle;
        }

        public void RunApp()
        {
            FillUpAvatarList();
            MakeANewUser(ChooseAName());
            _player.YourAvatar = validateInput(ChooseYourWarrior());
            Console.Clear();
            Console.WriteLine(_player.Description());
            Console.WriteLine("Lets go to Battle");
            var randomEnemy = _battle.GetRandomEnemy(AllAvatarsInTheGame);
            _battle.GoToBatle(_player.YourAvatar, randomEnemy);
            Console.WriteLine(_battle.WonOrLost(_player.YourAvatar, randomEnemy));
        }
        
        public void FillUpAvatarList()
        {
            AllAvatarsInTheGame.Add(new Warrior("Fire Warrior", 100, 60, 50));
            AllAvatarsInTheGame.Add(new Warrior("Water Warrior", 100, 50, 60));
            AllAvatarsInTheGame.Add(new Warrior("Electric Warrior", 100, 40, 70));

            AllAvatarsInTheGame.Add(new Enemie("Fire Bear", 100, 60, 50));
            AllAvatarsInTheGame.Add(new Enemie("Water Monster", 100, 50, 60));
            AllAvatarsInTheGame.Add(new Enemie("Electric Tiger", 100, 40, 70));
            AllAvatarsInTheGame.Add(new Enemie("Fire Dragon", 100, 60, 50));
            AllAvatarsInTheGame.Add(new Enemie("Giant", 100, 50, 60));
            AllAvatarsInTheGame.Add(new Enemie("Zoombie", 100, 40, 70));


        }
        public string ChooseAName()
        {
            Console.WriteLine("Write down your name");
            var name = Console.ReadLine();
            return name;
        }

        public void MakeANewUser(string name)
        {
            _player.Name = name;
           
        }
        public void ShowWarriorsToChoose()
        {
            foreach (var avatar in AllAvatarsInTheGame)
            {
                if (avatar is Warrior warrior)
                {
                   
                    Console.WriteLine(warrior.Description());
                }
            }
        }
        public string ChooseYourWarrior()
        {
            Console.WriteLine("Write down the element of the warrior you want");
            ShowWarriorsToChoose();
            return Console.ReadLine();



        }

        public Warrior validateInput(string ReadLine)
        {
            var readline = ReadLine.ToLower();
            while (true)
            {
               if(readline == "fire")
                {
                    if(AllAvatarsInTheGame[0] is Warrior w)
                    return w;
                }
               else if (readline == "water")
                {
                    if (AllAvatarsInTheGame[1] is Warrior w)
                        return w;
                }
                else if(readline == "electric")
                {
                    if (AllAvatarsInTheGame[2] is Warrior w)
                        return w;
                }
               else
                {
                    Console.WriteLine("Invalid Input, try again");
                    continue;
                }
             
                
            }


            
        }

      

    }
}

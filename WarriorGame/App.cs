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
            fillUpItemShopList();
            //FillUpAvatarList();

            //MakeANewUser(ChooseAName());
            //_player.YourAvatar = validateInput(ChooseYourWarrior());
            //Console.Clear();
            //Console.WriteLine(_player.Description());
            //Console.WriteLine("Lets go to Battle");
            //var randomEnemy = _battle.GetRandomEnemy(AllAvatarsInTheGame);
            //_battle.GoToBatle(_player.YourAvatar, randomEnemy);
            //Console.WriteLine(_battle.WonOrLost(_player.YourAvatar, randomEnemy));
            Console.WriteLine("Welcome the shop, u can buy potions and weapons here");
            ShowItemOnShop();
            var WorP =chooseWorPValidate();
            ShowWorP(WorP);
            ChooseItemToBuy();
            _shop.SelectedItem = ValidateItemBuy(WorP);
            Console.WriteLine(_shop.Buy(_player));

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

        public void fillUpItemShopList()
        {
            _shop.AllAvailableItems.Add(new Potion("Fire Potion", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Potion("Water Potion", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Potion("Rock Potion", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Potion("Electric Potion", 50, 25, 50, 0));

            _shop.AllAvailableItems.Add(new Weapon("Fire Weapon", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Weapon("Water Weapon", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Weapon("Rock Weapon", 50, 25, 50, 0));
            _shop.AllAvailableItems.Add(new Weapon("Electric Weapon", 50, 25, 50, 0));
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
        public void ChooseYourWarrior()
        {
            Console.WriteLine("Write down the element of the warrior you want");
            ShowWarriorsToChoose();
           



        }

        public Warrior validateInput() 
        {
            
            while (true)
            {
                var ReadLine = Console.ReadLine();
                var readline = ReadLine.ToLower();

                if (readline == "fire")
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
               
                
                    Console.WriteLine("Invalid Input, try again");
                    continue;
                
                
            }
          

        }
        public void ShowItemOnShop()
        {
            Console.Clear();
            showPotions();
            showWeapons();
            Console.WriteLine("Choose what kind of Item u want to buy. P for Potions, W for Weapons");

        }

        public void showPotions()
        {
            Console.WriteLine("POTIONS");
            var Potions = _shop.AllAvailableItems.FindAll(i => i is Potion p);
            for (int i = 0; i < Potions.Count; i++)
            {
                Potions[i].description();

                
                    Console.WriteLine($"{i} - {Potions[i].Description}");
                    Console.WriteLine("");
            }
        }

        

        public void showWeapons()
        {
            Console.WriteLine("WEAPONS");
            var Weapons = _shop.AllAvailableItems.FindAll(i => i is Weapon w);
            for (int i =0; i< Weapons.Count; i++)
            {
                Weapons[i].description();

                    Console.WriteLine($"{i} - {Weapons[i].Description}");
                    Console.WriteLine("");
                
            }

         
                

        }


        public string chooseWorPValidate()
        {
            
            while (true)
            {
                var UserInput = Console.ReadLine();
                var INPUT = UserInput.ToUpper();
                if (INPUT == "W")
                {
                    return "w";
                }
                else if(INPUT == "P")
                {
                    return "p";
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }
            }
        }

        public void ShowWorP(string WorP)
        {
            Console.Clear();
            if (WorP == "p") showPotions();
            else if(WorP == "w") showWeapons();
        }


        public void ChooseItemToBuy()
        {
            Console.WriteLine("Chose the item u want to buy by pressing the number in front of it");
        }

        public IItem ValidateItemBuy(string WorP)
        {
            while (true)
            {
                try
                {
                    var userInput = Convert.ToInt32(Console.ReadLine());
                    if(WorP == "w")
                    {
                       var Weapons = _shop.AllAvailableItems.FindAll(i => i is Weapon w);
                        return Weapons[userInput];
                    }
                    else if(WorP == "p")
                    {
                        var Potions = _shop.AllAvailableItems.FindAll(i => i is Potion p);
                        return Potions[userInput];
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, try again");
                        continue;
                    }

                 }
                catch
                 {
                     Console.WriteLine("Invalid Input, try again");
                     continue;
                 }
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class BattleField : IBattleField
    {
        public Avatar GetRandomEnemy(List<Avatar> allAvatars)
        {
            Random r = new Random();

            var AllEnemies = allAvatars.FindAll(a => a is Enemie e);
            var RandomE = r.Next(0, AllEnemies.Count);
            return AllEnemies[RandomE];

        }
        public void GoToBatle(Avatar Warrior, Avatar Enemie)
        {
            while (Warrior.Health > 0 && Enemie.Health > 0)
            {
                if(Warrior.Health > 0)
                {
                    Warrior.Attack(Enemie);
                    Console.WriteLine(Enemie.InBattleHealth());

                }
              if(Enemie.Health > 0)
                {
                    Enemie.Attack(Warrior);
                    Console.WriteLine(Warrior.InBattleHealth());
                }
               
            }


        }

        public string WonOrLost(Avatar Warrior, Avatar Enemie)
        {
            if (Warrior.Health == 0)
            {
                return "You lost the battle";
            }
            else

                return "You won the battle";

        }
    }
}

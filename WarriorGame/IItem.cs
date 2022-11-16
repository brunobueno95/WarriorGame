using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal interface IItem
    {
        string Name { get; set; }
        int price { get; set; }

        string Description { get; set; }
        public int PowerIncrease { get; set; }

        public int HealthIncrease { get; set; }

        public int SpeedIncrease { get; set; }

        void Use(User TheUser);

        void description();
        

    
    }
}

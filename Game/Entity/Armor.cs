using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    public class Armor
    {
        public string NameArmor;
        public int PriceArmor;
        public int DefenseBonusArmor;
        public int IndexArmor;
        public Armor() 
        {
            DefenseBonusArmor = 0;
            NameArmor = "Звичайна броня";
        }
    }
}

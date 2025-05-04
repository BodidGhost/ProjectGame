using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    public class Weapon
    {
        public string NameWeapon;
        public int PriceWeapon;
        public int AttackBonusWeapon;
        public int IndexWeapon;
        public Weapon() 
        {
            AttackBonusWeapon = 0;
            NameWeapon = "Звичайна зброя";
        }
    }
}

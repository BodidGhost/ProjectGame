using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity
{
    public class Accessory
    {
        public string NameAccessory;
        public int PriceAccessory;
        public int ManaBonusAccessory;
        public int IndexAccessory;
        public Accessory() 
        {
            ManaBonusAccessory = 0;
            NameAccessory = "Звичайний аксеруар";
        }
    }
}

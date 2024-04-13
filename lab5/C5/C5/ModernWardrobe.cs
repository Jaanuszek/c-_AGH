using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ModernWardrobe:Wardrobe
    {
       public bool IsSlidingDoors { get; set; }
       public int MirrorCount {  get; set; }
        public override string GetInfo()
        {
            return "Modern Wardrobe:  Price:" + price + " Color: " + color + " Material: " + material + " Number of Doors:" + NumberOfDoors;
        }
    }
}

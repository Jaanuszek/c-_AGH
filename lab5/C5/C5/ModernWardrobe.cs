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
        public ModernWardrobe(int price, string color, string material, int numDoors, bool isSliding, int mirrorCount)
        {
            Price = price;
            Color = color;
            Material = material;
            NumberOfDoors = numDoors;
            IsSlidingDoors = isSliding;
            MirrorCount = mirrorCount;
        }
        public override string GetInfo()
        {
            return "Modern Wardrobe:  Price:" + Price + " Color: "  + Color + " Material: " + Material + " Number of Doors:" + NumberOfDoors + " Sliding doors: " + IsSlidingDoors + " Mirror ammount: "+ MirrorCount;
        }
    }
}

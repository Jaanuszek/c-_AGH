using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ClassicalWardrobe : Wardrobe
    {
        public bool RealWood { get; set; }
        public bool HasOrnamentation { get; set; } //zdobienia
        public override string GetInfo()
        {
            return "Classical Wardrobe:  Price:" + price + " Color: " + color + " Material: " + material + " Number of Doors:" + NumberOfDoors + " Real wood: " + RealWood + " Ornaments: "+ HasOrnamentation;
        }
    }
}

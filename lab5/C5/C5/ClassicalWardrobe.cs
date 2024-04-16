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

        public ClassicalWardrobe(int price, string color, string material, int numDoors, bool realWood, bool hasOrnamentation)
        {
            Price= price;
            Color= color;
            Material= material;
            NumberOfDoors= numDoors;
            RealWood= realWood;
            HasOrnamentation= hasOrnamentation;
        }
        public override string GetInfo()
        {
            return "Classical Wardrobe:  Price:" + Price + " Color: " + Color + " Material: " + Material + " Number of Doors:" + NumberOfDoors + " Real wood: " + RealWood + " Ornaments: "+ HasOrnamentation;
        }
    }
}

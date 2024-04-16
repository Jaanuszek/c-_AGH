using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ScandinavianWardrobe : Wardrobe
    {
        public bool HasLegs { get; set; } // na google grafika jak patrze to niektore stoją na nogach, a niektore nie
        public string HandleType {  get; set; } // rodzaj uchwytow, w tym stylu raczej uchwyty nie rzucają sie w oczy
        public ScandinavianWardrobe(int price, string color, string material, int numDoors, bool hasLegs, string handleType)
        {
            Price = price;
            Color = color;
            Material = material;
            NumberOfDoors = numDoors;
            HasLegs = hasLegs;
            HandleType = handleType;
        }
        public override string GetInfo()
        {
            return "Scandinavian Wardrobe:  Price:" + Price + " Color: " + Color + " Material: " + Material + " Number of Doors:" + NumberOfDoors + " Handle type: "+ HandleType;
        }
    }
}

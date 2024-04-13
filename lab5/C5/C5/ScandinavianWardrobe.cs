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
        public override string GetInfo()
        {
            return "Scandinavian Wardrobe:  Price:" + price + " Color: " + color + " Material: " + material + " Number of Doors:" + NumberOfDoors;
        }
    }
}

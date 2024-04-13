using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    abstract class Wardrobe
    {
        public int price {  get; set; }
        public string color { get; set; }
        public string material {  get; set; }
        public int NumberOfDoors { get; set; }

        abstract public string GetInfo();

    }
}

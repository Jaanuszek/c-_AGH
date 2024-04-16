using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    abstract class Wardrobe
    {
        public int Price {  get; set; }
        public string Color { get; set; }
        public string Material {  get; set; }
        public int NumberOfDoors { get; set; }

        abstract public string GetInfo();

    }
}

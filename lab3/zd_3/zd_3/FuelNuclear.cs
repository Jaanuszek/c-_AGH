using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class FuelNuclear : Fuel
    {
        public FuelNuclear()
        {
            density = 0.8;
            material = "Nuclear";
        }
        public override double Volume
        {
            get { return volume; }
            set 
            { 
                volume = value;
                weight = value * density;
            }
        }
        public override double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / density;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Bus : Vehicle 
    {
        public Bus(string _engine, string _horsePower) : base(_engine, _horsePower) { }

        public override string GetVehicleType()
        {
            return "Bus";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + " Engine: " + Engine + " HorsePower: " + HorsePower;
        }
    }
}
}

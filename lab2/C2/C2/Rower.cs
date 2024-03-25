using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    public class Rower : Vehicle
    {
        public Rower(string _engine, string _horsePower) : base (_engine, _horsePower) { }

        public override string GetVehicleType()
        {
            return "rower";
        }
        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + " Engine: " + Engine + " HorsePower: " + HorsePower;
        }
    }
}

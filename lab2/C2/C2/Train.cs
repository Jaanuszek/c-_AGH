using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    public class Train :Vehicle
    {
        public Train(string _engine, string _horsePower) : base (_engine, _horsePower) { }
        public new virtual string GetVehicleType()
        {
            return "train";
        }

        public override string ToString()
        {
            return "Vehicle type: " + GetVehicleType() + " Engine: " + Engine + " HorsePower: " + HorsePower;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    abstract public class Vehicle
    {
        private string engine;
        private string horsePower;
        public Vehicle(string _engine, string _horsePower)
        {
            engine = _engine;
            horsePower = _horsePower;
        }
        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public string HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public virtual string GetVehicleType()
        {
            return "unspecified vehicle";
        }
    }
}

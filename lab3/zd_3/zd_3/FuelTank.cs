
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class FuelTank : IVisitPort
    {

        private Fuel fuel;

        public FuelTank(double capacity, Fuel fuel)
        {
            MaxCapacity = capacity;
            this.fuel = fuel;
        }
        public double Volume { 
            get { return fuel.Volume; }
            set {
                fuel.Volume = value;
                fuel.Weight = value * 0.8;
            }
        }
        public double Weight
        {
            get
            {
                return fuel.Weight;
            }
            set
            {
                fuel.Weight = value;
                fuel.Volume = value / 0.8;
            }
        }
        public double MaxCapacity { get; }

        public double VisitPort()
        {
            return fuel.Volume = MaxCapacity;

        }
        
        public string CheckFuelMaterial()
        {
            if(fuel.Material== "Nuclear")
            {
                return "Nuclear";
            }
            else
            {
                return "Diesel";
            }
        }

    }
}

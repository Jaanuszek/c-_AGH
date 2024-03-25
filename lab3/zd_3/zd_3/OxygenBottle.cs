
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class OxygenBottle : IVisitPort
    {
        protected double volume, weight, maxCapacity;
        public OxygenBottle(double capacity) { 
            maxCapacity = capacity;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 0.1;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 0.1;
            }
        }
        public double MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
        }
        public double VisitPort()
        {
            return volume = maxCapacity;
        }

    }
}

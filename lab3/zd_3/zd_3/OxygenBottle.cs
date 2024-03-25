
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
                weight = value * 0.5 + 13.7;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value +13.7; //waga butli z tlenem
                volume = value / 0.5;
            }
        }
        public double MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
        }
        public double VisitPort()
        {
            volume = maxCapacity;
            if (Volume > 10)
            {
                return volume * 10.0; //im wieksza butla tym taniej za litr wychodzi
            }
            else if(Volume <10 && Volume > 5)
            {
                return volume * 12.0;
            }
            else
            {
                return volume * 15.0;
            }
        }

    }
}

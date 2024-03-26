
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
                weight = value * 0.5 + 13.5;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value +13.5; //waga butli z tlenem
                volume = value / 0.5;
            }
        }
        public double MaxCapacity
        {
            get 
            { 
                return maxCapacity; 
            }
        }
        public double VisitPort()
        {
            volume = maxCapacity;
            if (Volume > 10)
            {
                return volume * 0.5; //im wieksza butla tym taniej za litr wychodzi
            }
            else if(Volume <10 && Volume > 5)
            {
                return volume * 1;
            }
            else
            {
                return volume * 1.5;
            }
        }

    }
}

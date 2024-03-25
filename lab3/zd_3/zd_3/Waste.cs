
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Waste : IVisitPort
    {
        protected double volume, weight;
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
        public double VisitPort()
        {
            volume = 0;
            return volume;
        }
    }
}

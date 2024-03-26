
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Waste : IVisitPort
    {
        private double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 0.01;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 0.01;
            }
        }
        public double VisitPort()
        {
            volume = 0;
            bool mixedWaste = new Random().Next(2)==0; // "==0" zeby przekształcić int na bool
            if( mixedWaste )
            {
                return volume * 0.2;
            }
            else 
            {
                return volume * 0.1;
            }

        }
    }
}

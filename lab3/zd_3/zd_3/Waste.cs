
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
                weight = value * 3;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 3;
            }
        }
        public double VisitPort()
        {
            volume = 0;
            bool mixedWaste = new Random().Next(2)==0; // "==0" zeby przekształcić int na bool
            if( mixedWaste )
            {
                return weight * 2.5;
            }
            else 
            {
                return weight * 0.5;
            }

        }
    }
}

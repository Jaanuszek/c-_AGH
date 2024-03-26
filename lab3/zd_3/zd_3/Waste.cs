
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
                if(value > 0)
                {
                    volume = value;
                }
                else
                {
                    volume = 0;
                }
                weight = value * 0.01;
            }

        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value>0)
                {
                    weight = value;
                }
                else 
                {
                    weight = 0;
                }
  
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

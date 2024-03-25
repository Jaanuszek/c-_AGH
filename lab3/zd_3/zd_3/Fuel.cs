
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    abstract class Fuel : ITransportable
    {
        protected double volume, weight;
        protected string material;

        protected double density;
        public virtual double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
                weight = value * density;
            }
        }
        public virtual double Weight { 
            get
            {
                return weight;
            }
            set
            {
                weight = value;
                volume = weight / density;
            }
        }
        public string Material
        {
            get
            {
                return material;
            }
        }

    }
}

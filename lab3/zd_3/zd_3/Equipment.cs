using System;
using System.Collections.Generic;
using System.Text;

namespace zd_3
{
    class Equipment : ITransportable
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }

            set
            {
                if(value > 0)
                {
                    volume = value;
                } // assume density equal to 7000 kg/m^3 (arbitrary number)
                else
                {
                    volume = 0;
                }
                weight = value * 2.0;
            }
        }
        public double Weight
        {
            get { return weight; }

            set
            {
                if(value > 0)
                { 
                    weight = value;
                } // assume density equal to 7000 kg/m^3 (arbitrary number)
                else
                {
                    weight = 0;
                }
                volume = value / 2.0;
            }
        }
        public void GatherData()
        {
            string data = "";
            for (int i = 0; i < 10; i++) data += (char)(new Random()).Next(128);
            Console.WriteLine("Important data gathered: " + data);
        }
    }
}

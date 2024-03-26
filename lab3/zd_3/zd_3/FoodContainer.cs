
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class FoodContainer : IVisitPort
    {
        protected double volume, weight, maxCapacity;
        public FoodContainer(double capacity) {
            maxCapacity = capacity;
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                if(value >0)
                { 
                    volume = value; 
                }
                else
                {
                    volume = 0;
                }
                weight = value * 0.5;
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

            string[] typeOfFood = { "Meat", "Vegetables", "Fruits" };
            int index = new Random().Next(typeOfFood.Length);
            if (typeOfFood[index] == "Meat")
            {
                return weight * 2;
            }
            else if (typeOfFood[index] == "Vegetables")
            {
                return weight * 0.5;
            }
            else
            {
                return weight * 1.5;
            }
        }
    }
}

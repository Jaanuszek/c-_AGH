using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        List<Human> crew;
        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            oxygenBottles = bottles;
            this.foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            if(travelTime < 1.0 && oxygenBottles.Count() >1 ) {
                return true;
            }
            else if (travelTime >10.0 && oxygenBottles.Count() >2)
            {
                return true;
            }
            else if(foodContainer.Weight < 1)
            {
                return false;
            }
            else if(travelTime<5 && foodContainer.Weight>10.0){
                return true;
            }
            else if (travelTime <=10.0 && foodContainer.Weight > 150.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Run(double travelTime) {
            var bottlesAmount = oxygenBottles.Count();
            double wasteAmmount = 0;
            if (bottlesAmount > 0)
            {
                foreach(var i in oxygenBottles)
                {
                    i.Volume -= 100.0;
                    if (i.Volume == 0) //jezeli wykorzysta sie butle z tlenem to sie ja zalicza jako odpad
                    {
                        wasteAmmount += 13.5;
                    }
                }
            }
            foodContainer.Weight -= travelTime * 5; // na godzine zuzywa sie 5 racji zywnosciowych
            wasteAmmount += travelTime * 0.5; // jak racja zywnosciowa zostanie zjedzona to zaliczamy to jako odpad
            waste.Weight += wasteAmmount;
            
        }
    }
}

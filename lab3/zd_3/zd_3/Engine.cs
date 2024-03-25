using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    class Engine
    {
        private FuelTank tank;
        private Waste waste;

        public Engine(FuelTank tank, Waste waste)
        {
            this.tank = tank;
            this.waste = waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            if(tank.CheckFuelMaterial() == "Nuclear")
            {
                return 100*0.01*submarineWeight;
            }
            else
            {
                return 70*0.01*submarineWeight;
            }
        }
        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (tank.Volume == 0)
            {
                return false;
            }
            else if (travelTime <10.0 && tank.Volume>25.0)
            {
                return true; //dorobic
            }
            else if (travelTime <100.0 && tank.Volume >75.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Travel(double travelTime)
        {
            tank.Weight -= 2.5*travelTime;
            waste.Weight += tank.Weight *travelTime;
        }
    }
}

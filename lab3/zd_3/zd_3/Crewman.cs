using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Crewman : Human
    {
        private double money = 50;

        public string drawTask()
        {
            int drawnNumber;
            drawnNumber = new Random().Next(0,100);
            if(drawnNumber < 25)
            {
                return "Clean floor";
            }
            else if (drawnNumber > 25 && drawnNumber < 50)
            {
                return "Refill fuel";
            }
            else if(drawnNumber > 50 && drawnNumber < 75)
            {
                return "Check oil";
            }
            else
            {
                return "Rest";
            }
        }
        public override void Work(double time)
        {
            string typeOfWork = drawTask();
            if(typeOfWork == "Rest")
            {
                money = 50;
            }
            else
            {
                money = money * time * 27.70;
            }
        }
    }
}

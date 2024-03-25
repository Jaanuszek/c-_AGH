using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Crewman : Human
    {
        public string drawTask()
        {
            int drawTask;
            drawTask = new Random().Next(0,100);
            if(drawTask < 25)
            {
                return "Clean floor";
            }
            else if (drawTask > 25 && drawTask < 50)
            {
                return "Refill fuel";
            }
            else if(drawTask > 50 && drawTask < 75)
            {
                return "Check oil";
            }
            else
            {
                return "Rest";
            }

        }
    }
}

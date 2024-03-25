
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class Scientist : Human
    {
        private Equipment equipment;
        public Scientist(Equipment equipment) { 
            this.equipment = equipment;
        }

        public override void Work(double time)
        {
            equipment.GatherData(); // zbiera dane na początku, a potem co 24 godziny
            int elapsedTime = 0;
            while(time > 0)
            {
                if(elapsedTime == 24)
                {
                    equipment.GatherData();
                }
                elapsedTime += 1;
                time -= 1;
            }
        }
    }
}

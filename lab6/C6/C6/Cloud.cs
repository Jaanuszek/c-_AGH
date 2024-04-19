using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C6
{
    class Cloud:DropOfWaterState
    {
        public Cloud(DropOfWaterSimulation simulation):base(simulation)
        {
            parentSimulation = simulation;
        }

        public override void Breathing()
        {
          
        }
        public override void Rainfall()
        {
            Random random = new Random();
            int choice = random.Next(1, 4);
            switch (choice)
            {
                case 1:
                    parentSimulation.ChangeState(new Plant(parentSimulation));
                    break;
                case 2:
                    parentSimulation.ChangeState(new Well(parentSimulation));
                    break;
                case 3:
                    parentSimulation.ChangeState(new River(parentSimulation));
                    break;
            }
        }
        public override void Evaporation()
        {

        }
        public override void Drinking()
        {

        }
        public override void Purification()
        {

        }
        public override void Excretion()
        {

        } 
        public override void FlowingInto()
        {

        } 
        public override string Info()
        {
            return "I am a cloud";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class Plant : DropOfWaterState
    {
        public Plant(DropOfWaterSimulation simulation) : base(simulation)
        {
            parentSimulation = simulation;
        }

        public override void Breathing()
        {
            parentSimulation.ChangeState(new Cloud(parentSimulation));
        }
        public override void Rainfall()
        {

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
                return "I am a Plant";
        }
    }
}

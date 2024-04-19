using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    internal class Well : DropOfWaterState
    {
        public Well(DropOfWaterSimulation simulation) : base(simulation)
        {
            parentSimulation = simulation;
        }

        public override void Breathing()
        {

        }
        public override void Rainfall()
        {

        }
        public override void Evaporation()
        {

        }
        public override void Drinking()
        {
            parentSimulation.ChangeState(new Human(parentSimulation));
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
            return "I am a Well";
        }
    }
}

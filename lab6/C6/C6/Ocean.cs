using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    internal class Ocean : DropOfWaterState
    {
        public Ocean(DropOfWaterSimulation simulation) : base(simulation)
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
            parentSimulation.ChangeState(new Cloud(parentSimulation));
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
            return "I am a Ocean";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    internal class Animal : DropOfWaterState
    {
        public Animal(DropOfWaterSimulation simulation) : base(simulation)
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
            parentSimulation.ChangeState(new River(parentSimulation));
        }
        public override void FlowingInto()
        {

        }
        public override string Info()
        {
            return "I am a Animal";
        }
    }
}

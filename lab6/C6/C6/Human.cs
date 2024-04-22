using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    internal class Human : DropOfWaterState
    {
        private string name;
        public Human(DropOfWaterSimulation simulation) : base(simulation)
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
            parentSimulation.ChangeState(new Sewage(parentSimulation));
        }
        public override void FlowingInto()
        {

        }
        public override string Info()
        {
            name = "Jakub";
            return "My name is: "+ name + " I am a human";
        }
    }
}

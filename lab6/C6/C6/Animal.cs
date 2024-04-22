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
            Random random = new Random();
            int choice = random.Next(1, 3);
            if(choice == 0)
            {
                return "WOOF WOOF I AM A DOG";
            }
            else if(choice == 1)
            {
                return "MUUU I AM A COW I NEED TO EAT MORE GRASS";
            }
            else if(choice == 2)
            {
                return "MIAU I AM A CAT";
            }
            else
            {
                return "RERE KUMKUM I AM A FROG";
            }
        }
    }
}

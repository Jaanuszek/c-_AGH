using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    abstract class DropOfWaterState
    {
        protected DropOfWaterSimulation parentSimulation;

        public DropOfWaterState(DropOfWaterSimulation sim)
        {
            parentSimulation = sim;
        }
        public abstract void Breathing();
        public abstract void Rainfall();
        public abstract void Evaporation(); //parowanie
        public abstract void Drinking();
        public abstract void Purification();
        public abstract void Excretion(); //wydalanie
        public abstract void FlowingInto(); //wpływanie do
        public abstract string Info();
    }
}

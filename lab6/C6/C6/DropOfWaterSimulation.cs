using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6
{
    class DropOfWaterSimulation
    {
        private DropOfWaterState currentState;

        public DropOfWaterSimulation()
        {
            currentState = new Cloud(this);
        }

        public string Info()
        {
            return currentState.Info();
        }
        public void ChangeState(DropOfWaterState state)
        {
            currentState = state;   
        }
        public void Breathing()
        {
            currentState.Breathing();
        }
        public void Rainfall()
        {
            currentState.Rainfall();
        }
        public void Evaporation()
        {
            currentState.Evaporation();
        }
        public void Drinking()
        {
            currentState.Drinking();
        }
        public  void Purification()
        {
            currentState.Purification();
        }
        public  void Excretion()
        {
            currentState.Excretion();
        }
        public  void FlowingInto()
        {
            currentState.FlowingInto();
        }
    }
}

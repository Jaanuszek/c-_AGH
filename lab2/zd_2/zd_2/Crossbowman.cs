using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_2
{
    public class Crossbowman :Defender
    {
        public override int Eat(int caloricDemand)
        {
            if(caloricDemand > 3000)
            {
                return 3;
            }
            else
            {
                return 2;
            }
        }

        public override string ReadyToFight()
        {
            return "My crossbow is ready to fire!";
        }
        public override string ToString()
        {
            return "crossbowman";
        }
    }
}

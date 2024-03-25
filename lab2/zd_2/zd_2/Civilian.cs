using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_2
{
    internal class Civilian : IResident
    {
        public int Eat(int caloricDemand)
        {
            if (caloricDemand > 2000)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return "civilian";
        }
    }
}

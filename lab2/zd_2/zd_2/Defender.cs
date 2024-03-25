using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_2
{
    public abstract class Defender : IResident
    {
        public abstract int Eat(int caloricDemand);
        public abstract string ReadyToFight();
    }
}

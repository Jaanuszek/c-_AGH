using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_2
{
    public class Pikeman : Defender
    {
        public override int Eat(int caloricDemand)
        {
            if (caloricDemand > 3500)
            {
                return 4;
            }
            else
            {
                return 3;
            }
        }

        public override string ReadyToFight()
        {
            return "Me and my pike are ready!";
        }

        public override string ToString()
        {
            return "pikeman";
        }
    }
}

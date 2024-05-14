using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class SpaceshipExtraCannon :Spaceship
    {
        public override int GetNextAttack()
        {
            Random RNG = new Random();
            if (RNG.Next(2) == 0) return base.GetNextAttack();
            else return base.GetNextAttack() + base.GetNextAttack();
        }
        public override string Type()
        {
            return "spaceship-cannon";
        }
    }
}

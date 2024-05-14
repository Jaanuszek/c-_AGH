using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class NanobotsDecorator : Decorator
    {
        public NanobotsDecorator(Spaceship ship) : base(ship)
        {
            //base.Health += 25;
        }
        public override int GetNextAttack()
        {
            Health += 25;
            ship.Health += 25;
            return ship.GetNextAttack();
        }
        public override string Type()
        {
            return base.Type() + " nanobots";
        }
    }
}

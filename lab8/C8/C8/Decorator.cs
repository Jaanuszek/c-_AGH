using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    abstract class Decorator : Spaceship
    {
        protected Spaceship ship;

        public override int GetNextAttack()
        {
            return ship.GetNextAttack();
        }

        public override string Type()
        {
            return ship.Type();
        }

        public Decorator(Spaceship spaceship)
        {
            ship = spaceship;
        }

    }
}

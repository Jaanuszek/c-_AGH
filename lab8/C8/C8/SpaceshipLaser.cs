using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class SpaceshipLaser :Spaceship
    {
        // spaceship with extra laser strength - more attack damage
        public SpaceshipLaser() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }
    }
}

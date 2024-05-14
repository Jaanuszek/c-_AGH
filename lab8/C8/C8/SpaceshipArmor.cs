using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class SpaceshipArmor : Spaceship
    {
        // spaceship with additional armor - more health points
        public SpaceshipArmor() : base()
        {
            Health += 150;
        }
        public override string Type()
        {
            return "spaceship-armor";
        }
    }
}

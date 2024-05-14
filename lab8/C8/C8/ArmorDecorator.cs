using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class ArmorDecorator : Decorator
    {
        public ArmorDecorator(Spaceship ship) : base(ship)
        {
            //base.Health += 150;
            base.Health += 150;
        }
        public override string Type()
        {
            return base.Type() + " armor";
        }
    }
}

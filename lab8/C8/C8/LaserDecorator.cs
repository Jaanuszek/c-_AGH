using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class LaserDecorator : Decorator
    {
        public LaserDecorator(Spaceship ship) : base(ship)
        {
            base.Attack += 50;
        }
        //public override int GetNextAttack()
        //{
        //    return base.GetNextAttack() + ship.Attack;
        //}
        public override string Type()
        {
            return base.Type() + " laser";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class ExtraCannonDecorator : Decorator
    {
        public ExtraCannonDecorator(Spaceship ship) : base(ship)
        {
            base.Attack += 50;
        }
        //public override int GetNextAttack()
        //{
        //    return base.GetNextAttack();
        //}
        public override string Type()
        {
            return base.Type() + " laser";
        }
    }
}

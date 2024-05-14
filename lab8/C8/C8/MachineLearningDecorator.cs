using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class MachineLearningDecorator : Decorator
    {
        public MachineLearningDecorator(Spaceship ship) : base(ship)
        {
            base.Attack += 25;
        }
        public override int GetNextAttack()
        {
            base.Attack += 25;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return base.Type() + " AI";
        }
    }
}

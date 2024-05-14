using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class SpaceshipMachineLearning : Spaceship
    {
        // spaceship with machine learning callibration - becomes stronger with every attack
        public override int GetNextAttack()
        {
            Attack += 25;
            return base.GetNextAttack();
        }
        public override string Type()
        {
            return "spaceship-AI";
        }
    }
}

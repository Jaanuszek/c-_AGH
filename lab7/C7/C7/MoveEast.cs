using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class MoveEast: Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("You are moving East.");
            if (currentTime >= 6 && currentTime <= 13)
            {
                Console.WriteLine("You cover your eyes because you're going under the sun");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class MoveWest : Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("You are moving West.");
            if (currentTime >= 14 && currentTime <= 20)
            {
                Console.WriteLine("You cover your eyes because you're going under the sun");
            }
        }
    }
}

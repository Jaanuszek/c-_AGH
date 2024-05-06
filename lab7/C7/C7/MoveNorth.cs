using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class MoveNorth :Move
    {
        public override void Execute(int currentTime)
        {
            Console.WriteLine("You are moving North.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    abstract class Ticket : IBuyTicket
    {
        public virtual float BuyTicket()
        {
            return 0;
        }
    }
}

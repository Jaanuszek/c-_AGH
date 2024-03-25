using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    public class dziedziczenie : IBuyTicket
    {
        int IBuyTicket.BuyTicket()
        {
            return 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    public enum TravelMode
    {
        Quickest,
        Cheapest,
        Convenient,
    }
    public abstract class TransportFactory
    {
        // currently selected travel mode
        public TravelMode travelMode = TravelMode.Quickest;

        abstract public Vehicle CreateVehicle();

        abstract public Ticket CreateTicket();

    }
}

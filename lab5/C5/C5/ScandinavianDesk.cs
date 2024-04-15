using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
     class ScandinavianDesk : Desk
    {
        public double LegWidth { get; set; }
        public bool IsCompact { get; set; }
        public override string GetInfo()
        {
            return "Scandinavian Desk: Price:" + price + " Thickness:" + thickness + " Durability: " + durability + " Leg width: "+ LegWidth + " Compact: "+IsCompact;
        }
    }
}

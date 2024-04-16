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
        public ScandinavianDesk(int price, float thickness, string dur, double legWidth, bool isCompact)
        {
            Price = price;
            Thickness = thickness;
            Durability = dur;
            LegWidth = legWidth;
            IsCompact = isCompact;
        }
        public override string GetInfo()
        {
            return "Scandinavian Desk: Price:" + Price + " Thickness:" + Thickness + " Durability: " + Durability + " Leg width: "+ LegWidth + " Compact: "+IsCompact;
        }
    }
}

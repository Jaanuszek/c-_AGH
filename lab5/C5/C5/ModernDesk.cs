using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ModernDesk : Desk 
    {
        public bool IsAdjustable { get; set; }
        public int ChargingSocketCount { get; set; }
        public int LedCount { get; set; }
        public override string GetInfo()
        {
            return "Modern Desk: Price:" + price + " Thickness:" + thickness + " Durability: " + durability + " Is adjustable: " + IsAdjustable + " Led ammount: " + LedCount;
        }
    }
}

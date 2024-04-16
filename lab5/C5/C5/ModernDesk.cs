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
        public ModernDesk(int price, float thickness, string dur, bool isAdjustable, int chargingSocketCount, int ledCount)
        {
            Price = price;
            Thickness = thickness;
            Durability = dur;
            IsAdjustable = isAdjustable;
            ChargingSocketCount = chargingSocketCount;
            LedCount = ledCount;
        }
        public override string GetInfo()
        {
            return "Modern Desk: Price:" + Price + " Thickness:" + Thickness + " Durability: " + Durability + " Is adjustable: " + IsAdjustable + " Led ammount: " + LedCount;
        }
    }
}

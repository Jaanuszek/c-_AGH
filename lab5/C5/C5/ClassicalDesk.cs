using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ClassicalDesk : Desk
    {
        public string WoodType { get; set; }
        public int DrawersCount { get; set; }
        public bool MetalDecorations {  get; set; }

        public ClassicalDesk(int price, float thickness, string dur, string woodType, int drawersCount, bool metalDecorations)
        {
            Price = price;
            Thickness = thickness;
            Durability = dur;
            WoodType = woodType;
            DrawersCount = drawersCount;
            MetalDecorations = metalDecorations;
        } 

        public override string GetInfo()
        {
            //return "Classical Desk: (Price : {Price},Thickness : {Thicness} Durability : {Durability}"; 
            return "Classical Desk: Price:" + Price + " Thickness:" + Thickness + " Durability: " + Durability + " Wood type: "+ WoodType + " DrawersCount: " + DrawersCount;
        }
    }
}

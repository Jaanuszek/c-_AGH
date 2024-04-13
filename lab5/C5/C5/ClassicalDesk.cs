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

        public override string GetInfo()
        {
            //return "Classical Desk: (Price : {Price},Thickness : {Thicness} Durability : {Durability}"; 
            return "Classical Desk: Price:" + price + " Thickness:" + thickness + " Durability: " + durability;
        }
    }
}

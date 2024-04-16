using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ModernDesign : InteriorDesigner
    {
        public override Desk CreateDesk(int priceLimit)
        {
            if (priceLimit < 500)
            {
                return null;
            }
            else if (priceLimit >=500 && priceLimit < 1400) 
            {
                //return new ModernDesk
                //{
                //    Price = 500,
                //    Thickness = 15,
                //    Durability = "Poor",
                //    IsAdjustable = false,
                //    ChargingSocketCount= 0,
                //    LedCount= 0
                //};
                return new ModernDesk(500, 15, "Poor", false, 0, 0);
            }
            else 
            {
                //return new ModernDesk
                //{
                //    Price = 1400,
                //    Thickness = 25,
                //    Durability = "Medium",
                //    IsAdjustable = true,
                //    ChargingSocketCount = 2,
                //    LedCount = 500
                //};
                return new ModernDesk(1400, 25, "Medium", true, 2, 500);
            }
        }
        public override Wardrobe CreateWardrobe(int priceLimit)
        {
            if (priceLimit < 650)
            {
                return null;
            }
            else if (priceLimit >650 && priceLimit < 2600)
            {
                //return new ModernWardrobe
                //{
                //    Price = 650,
                //    Color = "Light brown",
                //    Material = "Chipboard", //plyta wiórowa
                //    NumberOfDoors=2,
                //    IsSlidingDoors=false,
                //    MirrorCount = 0
                //};
                return new ModernWardrobe(540, "Light brown", "Chipboard", 2, false, 0);
            }
            else
            {
                //return new ModernWardrobe
                //{
                //    Price = 2600,
                //    Color = "Dark grey",
                //    Material = "Pine Wood", 
                //    NumberOfDoors = 2,
                //    IsSlidingDoors = true,
                //    MirrorCount = 2
                //};
                return new ModernWardrobe(2600, "Dark grey", "Pine Wood", 2, true, 2);
            }
        }
    }
}

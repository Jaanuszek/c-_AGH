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
                return new ModernDesk
                {
                    price = 500,
                    thickness = 15,
                    durability = "Poor",
                    IsAdjustable = false,
                    ChargingSocketCount= 0,
                    LedCount= 0
                };
            }
            else 
            {
                return new ModernDesk
                {
                    price = 1400,
                    thickness = 25,
                    durability = "Medium",
                    IsAdjustable = true,
                    ChargingSocketCount = 2,
                    LedCount = 500
                };
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
                return new ModernWardrobe
                {
                    price = 650,
                    color = "Light brown",
                    material = "Chipboard", //plyta wiórowa
                    NumberOfDoors=2,
                    IsSlidingDoors=false,
                    MirrorCount = 0
                };
            }
            else
            {
                return new ModernWardrobe
                {
                    price = 2600,
                    color = "Dark grey",
                    material = "Pine Wood", 
                    NumberOfDoors = 2,
                    IsSlidingDoors = true,
                    MirrorCount = 2
                };
            }
        }
    }
}

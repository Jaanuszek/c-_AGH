using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ScandinavianDesign : InteriorDesigner
    {
        public override Desk CreateDesk(int priceLimit)
        {
            if (priceLimit < 400)
            {
                return null;
            }
            else if (priceLimit >=400 && priceLimit < 800)
            {
                return new ScandinavianDesk
                {
                    price = 400,
                    thickness = 10,
                    durability = "poor",
                    LegWidth = 22.5 ,
                    IsCompact = false
                };
            }
            else
            {
                return new ScandinavianDesk
                {
                    price = 800,
                    thickness = 25,
                    durability = "medium",
                    LegWidth = 50,
                    IsCompact = true
                };
            }
        }
        public override Wardrobe CreateWardrobe(int priceLimit)
        {
            if(priceLimit < 549)
            {
                return null;
            }
            else if (priceLimit >549 && priceLimit <1299)
            {
                return new ScandinavianWardrobe
                {
                    price=549,
                    color = "white",
                    material = "plywood", //sklejka
                    NumberOfDoors = 1,
                    HasLegs = false,
                    HandleType = "none"
                };
            }
            else
            {
                return new ScandinavianWardrobe
                {
                    price = 1299,
                    color = "light blue",
                    material = "ash", //jesion
                    NumberOfDoors = 2,
                    HasLegs = true,
                    HandleType = "Leather Pulls"
                };
            }
        }
    }
}

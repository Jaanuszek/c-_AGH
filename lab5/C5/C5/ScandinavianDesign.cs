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
                //return new ScandinavianDesk
                //{
                //    Price = 400,
                //    Thickness = 10,
                //    Durability = "poor",
                //    LegWidth = 22.5 ,
                //    IsCompact = false
                //};
                return new ScandinavianDesk(400, 10, "poor", 22.5, false);
            }
            else
            {
                //return new ScandinavianDesk
                //{
                //    Price = 800,
                //    Thickness = 25,
                //    Durability = "medium",
                //    LegWidth = 50,
                //    IsCompact = true
                //};
                return new ScandinavianDesk(800, 25, "medium", 50, true);
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
                //return new ScandinavianWardrobe
                //{
                //    Price=549,
                //    Color = "white",
                //    Material = "plywood", //sklejka
                //    NumberOfDoors = 1,
                //    HasLegs = false,
                //    HandleType = "none"
                //};
                return new ScandinavianWardrobe(549, "white", "plywood", 1, false, "none");
            }
            else
            {
                //return new ScandinavianWardrobe
                //{
                //    Price = 1299,
                //    Color = "light blue",
                //    Material = "ash", //jesion
                //    NumberOfDoors = 2,
                //    HasLegs = true,
                //    HandleType = "Leather Pulls"
                //};
                return new ScandinavianWardrobe(1299, "light blue", "ash", 2, true, "Leather Pulls");
            }
        }
    }
}

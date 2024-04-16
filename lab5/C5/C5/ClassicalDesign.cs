using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    class ClassicalDesign :InteriorDesigner
    {
        public override Desk CreateDesk(int priceLimit)
        {
            if (priceLimit < 700)
            {
                return null;
            }
            else if (priceLimit >=700 && priceLimit < 2000)
            {
                //return new ClassicalDesk
                //{
                //    price = 700,
                //    thickness = 20,
                //    durability = "Medium",
                //    WoodType = "Pine",
                //    DrawersCount = 0,
                //    MetalDecorations = false
                //};
                return new ClassicalDesk(700, 20, "Medium", "Pine", 0, false);
            }
            else
            {
                //return new ClassicalDesk
                //{
                //    price = 2000,
                //    thickness = 30,
                //    durability = "Excellent",
                //    WoodType = "Oak",
                //    DrawersCount = 3,
                //    MetalDecorations = true
                //};
                return new ClassicalDesk(2000, 30, "Excellent", "Oak", 3, true);
            }
        }
        public override Wardrobe CreateWardrobe(int priceLimit)
        {
            if(priceLimit < 1000)
            {
                return null;
            }
            else if (priceLimit>1000 && priceLimit < 4000)
            {
                //return new ClassicalWardrobe
                //{
                //    Price = 1000,
                //    Color = "none",
                //    Material = "Artifical wood",
                //    NumberOfDoors = 2,
                //    RealWood = false,
                //    HasOrnamentation = false,
                //};
                return new ClassicalWardrobe(1000,"none", "Artifical wood", 2 , false, false);
            }
            else
            {
                //return new ClassicalWardrobe
                //{
                //    Price = 4000,
                //    Color = "none",
                //    Material = "Oak wood",
                //    NumberOfDoors = 4,
                //    RealWood = true,
                //    HasOrnamentation = true,
                //};
                return new ClassicalWardrobe(4000, "none", "Oak wood", 4, true, true);
            }
        }
    }
}

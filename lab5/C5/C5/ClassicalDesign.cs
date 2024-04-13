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
                return new ClassicalDesk
                {
                    price = 700,
                    thickness = 20,
                    durability = "Medium",
                    WoodType = "Pine",
                    DrawersCount = 0,
                    MetalDecorations = false
                };
            }
            else
            {
                return new ClassicalDesk
                {
                    price = 2000,
                    thickness = 30,
                    durability = "Excellent",
                    WoodType = "Oak",
                    DrawersCount = 3,
                    MetalDecorations = true
                };
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
                return new ClassicalWardrobe
                {
                    price = 1000,
                    NumberOfDoors = 2,
                    color = "none",
                    material = "Artifical wood",
                    RealWood = false,
                    HasOrnamentation = false,
                };
            }
            else
            {
                return new ClassicalWardrobe
                {
                    price = 4000,
                    NumberOfDoors = 4,
                    color = "none",
                    material = "Oak wood",
                    RealWood = true,
                    HasOrnamentation = true,
                };
            }
        }
    }
}

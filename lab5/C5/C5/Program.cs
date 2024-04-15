using System;

namespace C5
{
    class Program
    {
       static void Main(string[] args)
        {
            List<InteriorDesigner> interior = new List<InteriorDesigner>()
            {
                new ClassicalDesign(),
                new ModernDesign(),
                new ScandinavianDesign()
            };
            int[] priceLimits = { 300, 700, 5000 };
            foreach (InteriorDesigner des in interior)
            {
                foreach(var priceLimit in priceLimits)
                {
                    Desk d = des.CreateDesk(priceLimit);
                    Wardrobe w = des.CreateWardrobe(priceLimit);
                    Console.WriteLine("Price limit: "+priceLimit);
                    if(d!= null)
                    {
                        Console.WriteLine(d.GetInfo());
                    }
                    else
                    {
                        Console.WriteLine("No suitable Desk found in this price.");
                    }
                    if (w != null)
                    {
                        Console.WriteLine(w.GetInfo());
                    }
                    else
                    {
                        Console.WriteLine("No suitable Wardrobe found in this price.");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
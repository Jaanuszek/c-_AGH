using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    public enum DesignMode
    {
        Classical,
        Modern,
        Scandinavian
    };
    abstract class InteriorDesigner
    {
        public abstract Desk CreateDesk(int priceLimit);
        public abstract Wardrobe CreateWardrobe(int priceLimit);
    }
}

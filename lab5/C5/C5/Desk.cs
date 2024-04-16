using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    abstract class Desk
    {
        public int Price {  get; set; }
        public float Thickness { get; set; }
        public string Durability { get; set; }
        //public Desk(int price, float thickness, string dur)
        //{
        //    Price = price;
        //    Thickness = thickness;
        //    Durability = dur;
        //}
        public abstract string GetInfo();
    }
}

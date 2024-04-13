using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5
{
    abstract class Desk
    {
        public int price {  get; set; }
        public float thickness { get; set; }
        public string durability { get; set; }
        public abstract string GetInfo();
    }
}

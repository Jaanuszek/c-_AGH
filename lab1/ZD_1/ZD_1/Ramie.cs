using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD_1
{
    public class Ramie : Konczyna
    {
        public Ramie(int _iloscKosci, float _dlugosc, string _funkcja) : base(_iloscKosci, _dlugosc, _funkcja)
        {

        }

        public void Gestykuluj()
        {

        }
        public float Rzuc(float masaPrzedmiotu, float sila)
        {
            return sila / masaPrzedmiotu;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD_1
{
    public class Noga:Konczyna
    {
        public Noga(int _iloscKosci, float _dlugosc, string _funkcja) : base (_iloscKosci, _dlugosc, _funkcja)
        {

        }
        public string Biegnij(float iloscKilometrów)
        {
            if(iloscKilometrów > 5)
            {
                return "Odpocznij troche";
            }
            else
            {
                return "Ty sie w ogole zmeczyles?";
            }
        }
        public bool Podskocz(int wysokoscSkoku, int wysokoscPrzeszkody)
        {
            if (wysokoscSkoku > wysokoscPrzeszkody)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

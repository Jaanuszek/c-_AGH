using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD_1
{
    public class Dlon : Ramie
    {
        private bool kciuk;
        public Dlon(int _iloscKosci, float _dlugosc, string _funkcja, bool _kciuk) : base (_iloscKosci, _dlugosc, _funkcja)
        {
            kciuk = _kciuk;
        }

        public bool Chwytaj(int iloscPalców)
        {
            if (!kciuk)
            {
                if (iloscPalców < 1) {
                    return false;
                }
                else
                {
                    return true;
                }    
            }
            else
            {
                return true;
            }
        }

        public void PrzybijPione()
        {

        }
    }
}

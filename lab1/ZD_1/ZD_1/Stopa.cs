using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD_1
{
    public class Stopa : Noga
    {
        private bool plaskostopie;
        private int rozmiarButa;
        public Stopa(int _iloscKosci, float _dlugosc, string _funkcja, bool _plaskostopie, int _rozmiarButa) : base(_iloscKosci, _dlugosc, _funkcja)
        {
            plaskostopie = _plaskostopie;
            rozmiarButa = _rozmiarButa;
        }

    }
}

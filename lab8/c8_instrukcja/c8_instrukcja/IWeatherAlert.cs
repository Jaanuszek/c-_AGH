using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal interface IWeatherAlert
    {
        string CurrentDate { get; set; }
        void Alert();
    }
}

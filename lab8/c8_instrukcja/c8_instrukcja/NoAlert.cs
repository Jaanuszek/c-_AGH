using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class NoAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Date: " + CurrentDate);
        }
    }
}

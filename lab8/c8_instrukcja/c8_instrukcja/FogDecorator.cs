using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class FogDecorator : Decorator
    {
        public string CurrentDate { get; set; }
        public override void Alert()
        {
            base.Alert();
            Console.WriteLine("Date: " + CurrentDate);
            Console.Write("\t Alert: fog expected");
        }
        public FogDecorator(IWeatherAlert alert)
        {
            _weatherAlert = alert;
            CurrentDate = alert.CurrentDate;
        }
    }
}

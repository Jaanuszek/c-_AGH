using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class WindDecorator : Decorator
    {
        public string CurrentDate { get; set; }
        public override void Alert()
        {
            base.Alert();
            Console.WriteLine("Date: " + CurrentDate);
            Console.Write("\t Alert: wind expected");
        }
        public WindDecorator(IWeatherAlert alert)
        {
            _weatherAlert = alert;
            CurrentDate = alert.CurrentDate;
        }
    }
}

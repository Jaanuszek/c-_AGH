using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    abstract class Decorator : IWeatherAlert
    {
        protected IWeatherAlert _weatherAlert;
        public string CurrentDate { get; set; }
        public virtual void Alert()
        {
            _weatherAlert.Alert();
        }
    }
}

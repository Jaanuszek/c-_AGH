using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    class SetThermostatCommand : ISmartHomeExecutable
    {
        private Thermostat thermostat;
        private int temperature;
        public SetThermostatCommand(Thermostat _thermostat, int _temperature)
        {
            thermostat = _thermostat;
            temperature = _temperature;
        }
        public void Execute()
        {
            thermostat.TargetTemperature = temperature;
        }
    }
}

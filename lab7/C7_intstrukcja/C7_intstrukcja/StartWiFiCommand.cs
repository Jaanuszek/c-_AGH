using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    internal class StartWiFiCommand : ISmartHomeExecutable
    {
        private WiFi wifi;
        private string haslo;
        public StartWiFiCommand(WiFi _wifi, string _haslo)
        {
            wifi = _wifi;
            haslo = _haslo;
        }
        public void Execute()
        {
            wifi.IsCurrentlyOn = true;
            wifi.Login(haslo);
        }
    }
}

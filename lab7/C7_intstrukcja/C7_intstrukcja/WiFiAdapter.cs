using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    internal class WiFiAdapter : WiFi
    {
        private string network;
        private WiFi2 wifi2;

        public override bool IsCurrentlyOn
        {
            get { return wifi2.IsCurrentlyOn; }
            set { wifi2.IsCurrentlyOn = value; }
        }
        public override void Login(string pwd)
        {
            wifi2.Login(network, pwd);
        }   
        public  WiFiAdapter(WiFi2 _wifi, string _network) : base("","")
        {
            wifi2 = _wifi;
            network = _network;
        }
    }
}

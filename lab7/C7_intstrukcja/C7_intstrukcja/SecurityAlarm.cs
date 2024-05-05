using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    class SecurityAlarm
    {
        private string password;
        public bool Enterable { get; private set; }
        public void Lock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = false;
                Console.WriteLine("Security alarm is now active.");
            }
        }
        public void Unlock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = true;
            }
        }
        public SecurityAlarm(string pwd)
        {
            password = pwd;
            Enterable = false;
        }

    }
}

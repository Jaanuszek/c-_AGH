using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    class SmartHomeScheduler
    {
        public Dictionary<int, ISmartHomeExecutable> Commands { get; set; }
        public void Run()
        {
            for (int i = 0; i < 24; i++)
            {
                if (Commands.ContainsKey(i))
                {
                    Console.WriteLine(i + ":00");
                    Commands[i].Execute();
                }
            }
        }

        public SmartHomeScheduler()
        {
            Commands = new Dictionary<int, ISmartHomeExecutable>();
        }
    }
}

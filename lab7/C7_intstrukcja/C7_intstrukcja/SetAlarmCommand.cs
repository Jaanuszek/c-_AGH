using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_intstrukcja
{
    class SetAlarmCommand : ISmartHomeExecutable
    {
        private SecurityAlarm alarm;
        private string time;
        public SetAlarmCommand(SecurityAlarm _alarm, string _time)
        {
            alarm = _alarm;
            time = _time;
        }
        public void Execute()
        {
            alarm.Lock(time);
        }
    }
}

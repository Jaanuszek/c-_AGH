using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class OpenEndedQuestion : IAskable
    {
        public string Question { get; private set; }
        public int Points { get; private set; }
        public OpenEndedQuestion(string question, int points)
        {
            Question = question;
            Points = points;
        }
        public void Ask()
        {
            Console.WriteLine("(" + Points + " pkt) " + Question);
            Console.WriteLine("\n\n\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class ClosedEndedQuestion :IAskable
    {
        public string Question { get; private set; }
        public int Points { get; private set; }
        public List<string> PossibleAnswers { get; private set; }
        public ClosedEndedQuestion(string question, int points, List<string> answers)
        {
            Question = question;
            Points = points;
            PossibleAnswers = answers;
        }
        public void Ask()
        {
            Console.WriteLine("(" + Points + " pkt) " + Question);
            for (int i = 0; i < PossibleAnswers.Count; i++)
            {
                Console.Write(" " + ((char)(97 + i)).ToString() + ") " + PossibleAnswers[i]);
            }
            Console.WriteLine("\n");
        }
    }
}

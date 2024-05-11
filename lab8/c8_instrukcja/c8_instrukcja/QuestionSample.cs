using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c8_instrukcja
{
    internal class QuestionSample:IAskable
    {
        private List<IAskable> questions = new List<IAskable>();
        public void Add(IAskable question)
        {
            questions.Add(question);
        }
        public void Ask()
        {
            foreach (var q in questions)
            {
                q.Ask();
            }
        }
    }
}

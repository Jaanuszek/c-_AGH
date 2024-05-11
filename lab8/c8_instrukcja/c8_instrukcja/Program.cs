using c8_instrukcja;
using System;
using System.Collections.Generic;

namespace c8_instrukcja
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1
            ClosedEndedQuestion q1 = new ClosedEndedQuestion("Prosze zaznaczyc prawidlowa odpowiedz: przyspieszenie w ruchu jednostajnym",
                1, new List<string>() { "nie jest zdefiniowane", "zawsze wynosi zero", "jest zawsze dodatnie", "moze przyjmowac dowolna wartosc" });
            OpenEndedQuestion q2 = new OpenEndedQuestion("Prosze zapisac zasady dynamiki Newtona:", 2);
            OpenEndedQuestion q3 = new OpenEndedQuestion("Prosze wyprowadzic wzor na grawitacyjna energie potencjalna:", 3);
            QuestionSample s1 = new QuestionSample();
            s1.Add(q1);
            s1.Add(q2);
            s1.Add(q3);
            s1.Ask();


            // zadanie 2
            IWeatherAlert monday = new RainAlert();
            monday = new WindDecorator(monday);
            IWeatherAlert tuesday = new NoAlert();
            tuesday = new FogDecorator(tuesday);
            IWeatherAlert wednesday = new RainAlert();
            wednesday = new WindDecorator(wednesday);
            wednesday = new SnowDecorator(wednesday);
            Console.WriteLine("\nMonday");
            monday.Alert();
            Console.WriteLine("Tuesday");
            tuesday.Alert();
            Console.WriteLine("Wednesday");
            wednesday.Alert();


        }
    }
}
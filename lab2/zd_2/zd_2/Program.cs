using System;

namespace zd_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crosbowmans
            Crossbowman crossbowman1 = new Crossbowman();
            Crossbowman crossbowman2 = new Crossbowman();
            Crossbowman crossbowman3 = new Crossbowman();
            //Pikemans
            Pikeman pikeman1 = new Pikeman();
            Pikeman pikeman2 = new Pikeman();
            Pikeman pikeman3 = new Pikeman();
            //Civilians
            Civilian civilian1 = new Civilian();
            Civilian civilian2 = new Civilian();
            Civilian civilian3 = new Civilian();

            //lista wszystkich kusznikow
            List<Crossbowman> crossbowmans = new List<Crossbowman>();
            crossbowmans.Add(crossbowman1);
            crossbowmans.Add(crossbowman2);
            crossbowmans.Add(crossbowman3);

            //lista wszystkich obrońców
            List<Defender> defenders = new List<Defender>(); // lista wszystkich obroncow
            defenders.Add(crossbowman1);
            defenders.Add(crossbowman2);
            defenders.Add(crossbowman3);
            defenders.Add(pikeman1);
            defenders.Add(pikeman2);
            defenders.Add(pikeman3);

            // lista wszystkich mieszkancow
            List<IResident> residends = new List<IResident>();
            residends.Add(civilian1);
            residends.Add(civilian2);
            residends.Add(civilian3);
            residends.Add(pikeman3);
            residends.Add(pikeman2);
            residends.Add(pikeman1);
            residends.Add(crossbowman1);
            residends.Add(crossbowman2);
            residends.Add(crossbowman3);

            //ostatni podpunkt
            Console.WriteLine("Wszyscy Obroncy:\n");
            foreach (Defender defender in defenders) Console.WriteLine(defender.ReadyToFight()); // wywolanie funkcji ReadyToFight wszystkich obroncow
            Console.WriteLine("\nWszyscy Kusznicy:\n");
            foreach(Crossbowman crossbowman in crossbowmans) Console.WriteLine(crossbowman.ReadyToFight());
            Console.WriteLine("\nWszyscy mieszkancy:\n");
            int i = 2000;
            foreach (IResident resident in residends)
            {
                Console.WriteLine("The amount of food rations needed: " + resident.Eat(i) + " civil status: " +resident.ToString());
                i += 500;
            }

        }
    }
}
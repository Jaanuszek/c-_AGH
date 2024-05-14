using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C8
{
    internal class RunBattle
    {
        public static void Run()
        {
            // prepare spaceships
            Spaceship s1 = new SpaceshipArmor();
            Spaceship s2 = new SpaceshipLaser();
            Spaceship s3 = new SpaceshipExtraCannon();
            Spaceship s4 = new SpaceshipMachineLearning();
            Spaceship s5 = new SpaceshipNanobots();
            //List<Spaceship> tournamentList = new List<Spaceship>() { s1,s2,s3,s4,s5 };
            //s1 = new LaserDecorator(s1);
            //s2= new ExtraCannonDecorator(s2);
            //s3 = new MachineLearningDecorator(s3);
            //s4 = new NanobotsDecorator(s4);
            //s5 = new ArmorDecorator(s5);
            Decorator decoratedS1 = new LaserDecorator(s1);
            Decorator decoratedS2 = new ExtraCannonDecorator(s2);
            Decorator decoratedS3 = new MachineLearningDecorator(s3);
            Decorator decoratedS4 = new NanobotsDecorator(s4);
            Decorator decoratedS5 = new ArmorDecorator(s5);

            List<Spaceship> tournamentList = new List<Spaceship>() { decoratedS1,decoratedS2,decoratedS3,decoratedS4,decoratedS5 };

            // run tournament
            for (int i = 0; i < tournamentList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // remember original statistics
                    int hp1 = tournamentList[i].Health;
                    int hp2 = tournamentList[j].Health;
                    int at1 = tournamentList[i].Attack;
                    int at2 = tournamentList[j].Attack;
                    // play this round
                    Console.WriteLine();
                    Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    do
                    {
                        int attack1 = tournamentList[i].GetNextAttack();
                        int attack2 = tournamentList[j].GetNextAttack();
                        tournamentList[j].Health -= attack1;
                        tournamentList[i].Health -= attack2;
                        Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    } while (tournamentList[j].Health > 0 && tournamentList[i].Health > 0);
                    if (tournamentList[j].Health > tournamentList[i].Health) Console.WriteLine("winner: " + tournamentList[j].Type());
                    else if (tournamentList[i].Health > tournamentList[j].Health) Console.WriteLine("winner: " + tournamentList[i].Type());
                    else Console.WriteLine("draw!");
                    // restore original statistics
                    tournamentList[i].Health = hp1;
                    tournamentList[j].Health = hp2;
                    tournamentList[i].Attack = at1;
                    tournamentList[j].Attack = at2;
                }
            }

        }
    }
}

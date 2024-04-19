
using C6;
using System.Reflection;

DropOfWaterSimulation simulation = new DropOfWaterSimulation();
int i = 0;
do
{
    Console.WriteLine(i+1 + ": Scenario");
    Console.WriteLine(simulation.Info());
    simulation.Rainfall();
    Console.WriteLine(simulation.Info());
    if (simulation.Info() == "I am a Plant")
    {
        simulation.Breathing();
        Console.WriteLine(simulation.Info());
    }
    else if (simulation.Info() == "I am a Well")
    {
        simulation.Evaporation();
        Console.WriteLine(simulation.Info());
        simulation.Drinking();
        Console.WriteLine(simulation.Info());
        simulation.Excretion();
        Console.WriteLine(simulation.Info());
        simulation.Purification();
        Console.WriteLine(simulation.Info());
        simulation.Evaporation();
        Console.WriteLine(simulation.Info());
    }
    else if (simulation.Info() == "I am a river")
    {
        simulation.Drinking();
        Console.WriteLine(simulation.Info());
        simulation.Excretion();
        Console.WriteLine(simulation.Info());
        simulation.Drinking();
        Console.WriteLine(simulation.Info());
        simulation.Breathing();
        Console.WriteLine(simulation.Info());
    }
    i++;
    Thread.Sleep(3000);
} while (i <= 3);
//Thread.Sleep(3000);

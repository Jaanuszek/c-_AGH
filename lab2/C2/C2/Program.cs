using System;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle();
            //Train train = new Train("2jz", "500");
            //Console.WriteLine(train);
            List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("2jz", "500"));
            myVehicles.Add(new Bicycle("brak", "1"));
            myVehicles.Add(new Car("1.8TDI", "150"));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v.ToString());

        }
    }
}
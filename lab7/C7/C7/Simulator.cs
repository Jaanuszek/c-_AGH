using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7
{
    internal class Simulator
    {
        private List<string> moves = new List<String> { };
        public void Memorize()
        {
            bool finished = false;
            Console.WriteLine("Press key to move (W, S, D, A, Up, Down, Right, Left), accept (Enter), or remove (BackSpace):");
            while (!finished)
            {
                
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.W:
                        moves.Add("North");
                        break;
                    case ConsoleKey.S:
                        moves.Add("South");
                        break;
                    case ConsoleKey.D:
                        moves.Add("East");
                        break;
                    case ConsoleKey.A:
                        moves.Add("West");
                        break;
                    case ConsoleKey.UpArrow:
                        moves.Add("North");
                        break;
                    case ConsoleKey.DownArrow:
                        moves.Add("South");
                        break;
                    case ConsoleKey.RightArrow:
                        moves.Add("East");
                        break;
                    case ConsoleKey.LeftArrow:
                        moves.Add("West");
                        break;
                    case ConsoleKey.Backspace:
                        if (moves.Count > 0)
                        {
                            moves.RemoveAt(moves.Count - 1);
                        }
                        break;
                    case ConsoleKey.Enter:
                        finished = true;
                        break;
                    default:
                        Console.WriteLine("Wrong key pressed");
                        break;
                }
            }
            SaveToFile();
            Run();
        }

        public void Run()
        {
            int i = 6;
            while(moves.Count > 0)
            {
                string move = moves[0];
                Console.WriteLine(i + ":00");
                switch (move)
                {
                    case "North":
                        new MoveNorth().Execute(i);
                        break;
                    case "South":
                        new MoveSouth().Execute(i);
                        break;
                    case "East":
                        new MoveEast().Execute(i);
                        break;
                    case "West":
                        new MoveWest().Execute(i);
                        break;
                }
                moves.RemoveAt(0);
                i++;
                if(i>24)
                {
                    i = 0;
                }  
            }
        }
        public void SaveToFile()
        {
            string path = "C:\\Users\\Kuba\\Desktop\\studia\\SEMESTR 6\\c#_AGH\\lab7\\C7\\Log.txt";
            try
            {
                System.IO.File.WriteAllLines(path, moves);
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Error: " + dirEx.Message);
            }
        }
        public Simulator()
        {
            moves = new List<string> { };
        }
    }
}

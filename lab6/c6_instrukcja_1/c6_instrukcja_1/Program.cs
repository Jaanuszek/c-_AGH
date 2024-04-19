using System;

namespace c6_instrukcja_1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameApp gameApp = new GameApp();

            while (true)
            {
                Console.WriteLine("Wybierz akcję:");
                Console.WriteLine("1. Enter");
                Console.WriteLine("2. Escape");
                Console.WriteLine("3. Tab");
                Console.WriteLine("4. Keyboard Input");
                Console.WriteLine("5. Wyjdź");

                var key = Console.ReadKey();

                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        gameApp.EnterButton();
                        break;
                    case '2':
                        gameApp.EscapeButton();
                        break;
                    case '3':
                        gameApp.TabButton();
                        break;
                    case '4':
                        Console.WriteLine("Wprowadź tekst:");
                        string input = Console.ReadLine();
                        gameApp.KeyboardInput(input);
                        break;
                    case '5':
                        return; // zakończ program
                    default:
                        Console.WriteLine("Nieznana akcja. Wybierz ponownie.");
                        break;
                }

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
                Console.Clear(); // wyczyść konsolę po każdej akcji
            }
        }
    }
}

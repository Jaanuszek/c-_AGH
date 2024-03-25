// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(CountSolutions(25,5));
        }
        static double Pythagoras(double a, double b)
        {
            double result;
            result = Math.Sqrt(a * a + b * b);
            return result;
        }

        static bool IsPrime(int a)
        {
            if (a < 2)
            {
                return false;
            }
            for(int i =2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int Power(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Power(n - 1);
            }
        }
        static void PrintFactorial(int m)
        {
            if (m > 0)
            {
                Console.WriteLine("Factorial of " + m + " is eqyal to: " + Power(m));
            }
            else
            {
                Console.WriteLine("ERROR! CANNOT COMPUTE FACTORIAL OF A NEGATIVE NUMBER: " + m);
            }
        }
        static int zadI()
        {
            int wynik = 0;
            for (int i =1; i <= 40; i++)
            {
                if (i % 7 == 0)
                {
                    wynik += i;
                }
            }
            return wynik;
        }
        static int CountSolutions(int sum, int n)
        {
            if (n == 1)
            {
                return 1;
            }
            int wynik =0;
            for(int i = 1; i <= sum; i++)
            {
                wynik += CountSolutions(sum - i, n - 1);
            }
            return wynik;

        }
    }
}


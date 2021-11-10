using System;

namespace ActividadesCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciSerie = new int[100];
            for (int i = 0; i < fibonacciSerie.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacciSerie[i]++;
                }
                else
                {
                    fibonacciSerie[i] = (fibonacciSerie[i - 1] + fibonacciSerie[i - 2]);
                }
            }
            printFibonacciSerie(ref fibonacciSerie);
            Console.ReadKey();
        }

        static void printFibonacciSerie(ref int[] fibonacciSerie)
        {
            for (int i = 0; i < fibonacciSerie.Length; i++)
            {
                Console.WriteLine(fibonacciSerie[i]);
            }
        }
    }
}
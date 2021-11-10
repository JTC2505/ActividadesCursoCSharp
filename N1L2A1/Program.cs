using System;

namespace ActividadesCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciSerie = new int[100];
            fibonacciSerie[0]++;
            fibonacciSerie[1]++;
            for (int i = 2; i < fibonacciSerie.Length; i++)
            {
                fibonacciSerie[i] = (fibonacciSerie[i - 1] + fibonacciSerie[i - 2]);
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
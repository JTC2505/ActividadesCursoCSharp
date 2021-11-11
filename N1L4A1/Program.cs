using System;

namespace ActividadesCursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vec1 = new double[5];
            double[] vec2 = new double[5];
            double[] vecRes = new double[5];
            llenar(vec1, "1");
            llenar(vec2, "2");


            Console.ReadKey();
        }

        static void llenar(double[] vector, string num)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero {i} del vector {num}: ");
                vector[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("");
        }


    }
        interface IOperaciones
        {
            void suma(double num1, double num2);
            void resta(double num1, double num2);
            void multiplicación(double num1, double num2);
            void división(double num1, double num2);
        }
    public class operaciones : IOperaciones
    {
        public static double resultado
        {
            get;
            set;
        }

        public void división(double num1, double num2)
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("No es posible dividir dentro de 0");
            }
        }

        public void multiplicación(double num1, double num2)
        {
            resultado = num1 * num2;
        }

        public void resta(double num1, double num2)
        {
            resultado = num1 - num2;
        }

        public void suma(double num1, double num2)
        {
            resultado = num1 + num2;
        }
    }

    public delegate void DelOperaciones(double num1, double num2);
}
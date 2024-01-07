using System;

namespace Setul2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
            double[] secventa = { 1, 2, 3, 4, 5 };
            double sumaInverselor = SumaDeInverse(secventa);
            Console.WriteLine("Suma inverselor este: " + sumaInverselor );

        }
        static double SumaDeInverse(double[] numere)
        {
            double suma = 0;
            foreach (double num in numere)
            {
                suma += 1.0 / num;
            }
            return suma;
        }
    }
}